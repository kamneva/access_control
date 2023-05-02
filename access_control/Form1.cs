using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace access_control
{
    public partial class Form1 : Form
    {
        private logForm log;
        private changePasswordForm changePass;
        private addUserForm addUser;
        private showUserForm showUsers;
        private dbDecryptForm dbDecrypt;

        public User[] users;
        public User currentUser;
        private byte[] cryptKey = null;

        private string dbPath = "b.txt";

        public Form1()
        {
            InitializeComponent(); 
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                       "Выполнил: студент группы ИДБ-18-04 Камнева О.Ю.\n" +
                       "Индивидуальное задание: Наличие букв, цифр и знаков препинания в пароле",
                       "",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1);
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            log = new logForm(this);
            DialogResult logged = log.ShowDialog();
            if (logged == DialogResult.OK)
            {
                if (currentUser == null)
                {
                    MessageBox.Show("При входе произошла ошибка!");
                    this.Close();
                }

                if(currentUser.Blocked)
                {
                    MessageBox.Show("Данный пользователь заблокирован!");
                    this.Close();
                }

                bool needNewPassword = false;
                if(currentUser.Restricted)
                    needNewPassword = !changePasswordForm.CheckRestrictions(currentUser.Password);
                if (needNewPassword)
                    MessageBox.Show("Ваш пароль не соответствует ограничениям. Смените пароль.");

                if (currentUser.Password == "" || needNewPassword)
                {
                    changePass = new changePasswordForm(this);
                    if (changePass.ShowDialog() != DialogResult.OK)
                        this.Close();
                }

                label1.Visible = true;
                сменаПароляToolStripMenuItem.Enabled = true;
                выходToolStripMenuItem.Enabled = true;
                if (currentUser.Username == "admin")
                {
                    новыйПользовательToolStripMenuItem.Enabled = true;
                    всеПользователиToolStripMenuItem.Enabled = true;
                }
                else
                {
                    новыйПользовательToolStripMenuItem.Enabled = false;
                    всеПользователиToolStripMenuItem.Enabled = false;
                }

                LogIn.Visible = false;
            }
            else if (logged == DialogResult.Abort)
            {
                this.Close();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                       "Вы действительно хотите выйти?\n",
                       "Внимание!",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Asterisk,
                       MessageBoxDefaultButton.Button1) ;
            
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                           "Выход из системы был успешно выполнен!\n",
                           "",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information,
                           MessageBoxDefaultButton.Button1);
                label1.Visible = false;
                сменаПароляToolStripMenuItem.Enabled = false;
                выходToolStripMenuItem.Enabled = false;
                новыйПользовательToolStripMenuItem.Enabled = false;
                всеПользователиToolStripMenuItem.Enabled = false;
                LogIn.Visible = true;
            }
        }

        private void всеПользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUsers = new showUserForm(this);
            showUsers.Show();
        }

        private void новыйПользовательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addUser = new addUserForm(this);
            if(addUser.ShowDialog() == DialogResult.OK)
            {
                Array.Resize(ref users, users.Length + 1);
                users[users.Length - 1] = addUser.newUser;
            }

        }

        private void сменаПароляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changePass = new changePasswordForm(this);
            changePass.ShowDialog();
        }

        private void readKey()
        {
            try
            {
                using (FileStream fs = new FileStream(dbPath, FileMode.Open))
                {
                    byte[] key = new byte[32];
                    if (fs.Read(key, 0, 32) == key.Length)
                        cryptKey = key;
                }
            }
            catch (FileNotFoundException fe)
            {
                cryptKey = null;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private User[] readDatabase()
        {
            User[] decUsers = new User[0];

            try
            {
                using (FileStream fs = new FileStream(dbPath, FileMode.Open))
                {
                    byte[] key = new byte[32];
                    if (fs.Read(key, 0, 32) < key.Length)
                        throw new FileNotFoundException();

                    AesCryptoServiceProvider aesp = new AesCryptoServiceProvider();
                    aesp.KeySize = 256;
                    aesp.BlockSize = 128;
                    aesp.Mode = CipherMode.ECB;
                    aesp.Padding = PaddingMode.Zeros;

                    aesp.Key = key;
                    byte[] iv = new byte[16];
                    Array.Clear(iv, 0, iv.Length);
                    aesp.IV = iv;

                    ICryptoTransform decryptor = aesp.CreateDecryptor(aesp.Key, aesp.IV);

                    using (CryptoStream csDecrypt = new CryptoStream(fs, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt, Encoding.GetEncoding("windows-1251")))
                        {
                            while (srDecrypt.Peek() >= 0)
                            {
                                User u = readUser(srDecrypt);
                                if (u != null)
                                {
                                    Array.Resize(ref decUsers, decUsers.Length + 1);
                                    decUsers[decUsers.Length - 1] = u;
                                }
                            }
                        }
                    }
                }

                return decUsers;
            }
            catch (FileNotFoundException fs)
            {
                User admin = new User("admin", "");
                User[] dbUsers = { admin };
                return dbUsers;
            }
        }

        void writeDatabase()
        {
            using (FileStream fs = new FileStream(dbPath, FileMode.Create))
            {
                fs.Write(cryptKey, 0, 32);

                AesCryptoServiceProvider aesp = new AesCryptoServiceProvider();
                aesp.KeySize = 256;
                aesp.BlockSize = 128;
                aesp.Mode = CipherMode.ECB;
                aesp.Padding = PaddingMode.Zeros;

                aesp.Key = cryptKey;
                byte[] iv = new byte[16];
                Array.Clear(iv, 0, iv.Length);
                aesp.IV = iv;

                ICryptoTransform encryptor = aesp.CreateEncryptor(aesp.Key, aesp.IV);

                using (CryptoStream csEncrypt = new CryptoStream(fs, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt, Encoding.GetEncoding("windows-1251")))
                    {
                            foreach (User u in users)
                                writeUser(swEncrypt, u);
                    }
                }
            }
        }

        private void writeUser(StreamWriter sw, User user)
        {
            sw.WriteLine(user.Username);
            sw.WriteLine(user.Password);
            sw.WriteLine("{0}{1}",
                        user.Blocked ? "1" : "0",
                        user.Restricted ? "1" : "0");
        }

        private User readUser(StreamReader sr)
        {
            User user = new User();
            user.Username = sr.ReadLine();
            user.Password = sr.ReadLine();
            string flags = sr.ReadLine();
            if (flags == null)
                return null;
            if (flags[0] == '0')
                user.Blocked = false;
            else if (flags[0] == '1')
                user.Blocked = true;
            else
                return null;

            if (flags[1] == '0')
                user.Restricted = false;
            else if (flags[1] == '1')
                user.Restricted = true;
            else
                return null;

            if (user.Username == null ||
                user.Password == null ||
                user.Username == "")
                return null;
            else
                return user;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (users != null)
                writeDatabase();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readKey();
            dbDecrypt = new dbDecryptForm(this, cryptKey);
            if (dbDecrypt.ShowDialog() == DialogResult.OK)
            {
                if (cryptKey == null)
                    cryptKey = dbDecrypt.enteredKey;
                users = readDatabase();
                string str = null;
                    foreach (User val in users)
                    {
                     str += string.Format("Логин: " + val.Username + "\tПароль: "+ val.Password + "\tБлокировка: "+ val.Blocked + "\tОграничение: " + val.Restricted + "\n");
     
                    }
                System.IO.File.AppendAllText("C:\\Users\\olech\\OneDrive\\Desktop\\access_control\\TestFile.txt", str);
                
            }
            else
                this.Close();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
