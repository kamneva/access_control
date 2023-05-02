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
    public partial class addUserForm : Form
    {
        Form1 mainform;
        public User newUser = null;

        public addUserForm(Form1 main)
        {
            InitializeComponent();
            mainform = main;
        }

        private void okBut_Click(object sender, EventArgs e)
        {
            string username = newUserBox.Text;
            if (username == "")
            {
                MessageBox.Show("Имя пользователя не может быть пустым!");
                this.DialogResult = DialogResult.None;
            }
            else
            {
                bool found = false;
                foreach (User val in mainform.users)
                    if (val.Username == username)
                    {
                        found = true;
                        break;
                    }

                if (found)
                {
                    MessageBox.Show("Такой пользователь уже существует!");
                    this.DialogResult = DialogResult.None;
                }
                else
                {
                    newUser = new User(username);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void cancelBut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            this.Close();
        }
    }
}
