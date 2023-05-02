using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace access_control
{
    public partial class changePasswordForm : Form
    {
        private Form1 mainform;
        private int triesCount = 0;

        public changePasswordForm(Form1 main)
        {
            InitializeComponent();
            mainform = main;
        }

        private void okBut_Click(object sender, EventArgs e)
        {
            String oldpswd = oldPass.Text;
            String newpswd = newPass.Text;

            if (oldpswd != mainform.currentUser.Password)
            {
                triesCount++;
                if (triesCount == 3)
                    this.DialogResult = DialogResult.Abort;
                else { 
                MessageBox.Show("Неправильно введён старый пароль!");
                this.DialogResult = DialogResult.None;
                }
            }
            else
            {
                if(newpswd != verify.Text)
                {
                    MessageBox.Show("Новые пароли не совпадают!");
                    this.DialogResult = DialogResult.None;
                }
                else
                {
                    if (newpswd == "")
                    {
                        MessageBox.Show("Пароль не может быть пустым!");
                        this.DialogResult = DialogResult.None;
                    }
                    else
                    {

                        if (mainform.currentUser.Restricted)
                            if (CheckRestrictions(newpswd))
                                this.DialogResult = DialogResult.OK;
                            else
                            {
                                MessageBox.Show("Новый пароль не соответствует ограничениям!");
                                this.DialogResult = DialogResult.None;
                            }
                        else
                            this.DialogResult = DialogResult.OK;
                    }
                }
            }

            if (this.DialogResult == DialogResult.OK)
                mainform.currentUser.Password = newpswd;
        }

        private void cancelBut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        public static bool CheckRestrictions(String pswd)
        {

            if (Regex.IsMatch(pswd, @"\d") && (Regex.IsMatch(pswd, @"[А-Яа-я]") ||
               Regex.IsMatch(pswd, @"[A-Z]") || Regex.IsMatch(pswd, @"[a-z]")) &&
               Regex.IsMatch(pswd, @"[0-9]") && (Regex.IsMatch(pswd, @"[,]") ||
               Regex.IsMatch(pswd, @"[.]") || Regex.IsMatch(pswd, @"[!]") ||
               Regex.IsMatch(pswd, @"[?]") || Regex.IsMatch(pswd, @"[:]") || Regex.IsMatch(pswd, @"[;]") ||
               Regex.IsMatch(pswd, @"[-]") || Regex.IsMatch(pswd, @"[(]") || Regex.IsMatch(pswd, @"[)]")))
                return true;
            else return false;
        }

        private void newPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void oldPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
