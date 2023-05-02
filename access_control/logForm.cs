using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace access_control
{
    public partial class logForm : Form
    {
        public User user;
        public Form1 mainform;
        private int triesCount = 0;

        public logForm(Form1 main)
        {
            InitializeComponent();
            mainform = main;
        }

        private void okBut_Click(object sender, EventArgs e)
        {
            
            user = new User(login.Text, pswd.Text);
            bool userExist = false;
            User realUser = null;

            foreach (User val in mainform.users)
            {
                if (user.Username == val.Username)
                {
                    userExist = true;
                    realUser = val;
                    break;
                }
            }

            if (!userExist)
            {
                MessageBox.Show("Пользователь не найден!");
                this.DialogResult = DialogResult.None;
            }
            else
            {
                if (user.Password == realUser.Password)
                {
                    mainform.currentUser = realUser;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    triesCount++;
                    if (triesCount == 3)
                    {
                        MessageBox.Show(
                       "Превышено количество попыток!\n" +
                       "Программа завершает свою работу",
                       "Внимание!",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error,
                       MessageBoxDefaultButton.Button1);
                        this.DialogResult = DialogResult.Abort;
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль!");
                        this.DialogResult = DialogResult.None;
                    }
                }
            }
            
        }

        private void pswd_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelBut_Click(object sender, EventArgs e)
        {

        }

        private void logForm_Load(object sender, EventArgs e)
        {

        }
    }
}
