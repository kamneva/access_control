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
    public partial class showUserForm : Form
    {
        public Form1 mainform;
        private int index = 0;

        public showUserForm(Form1 main)
        {
            InitializeComponent();
            mainform = main;
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 0)
                index = mainform.users.Length - 1;
            showUserData(false);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            index++;
            if (index >= mainform.users.Length)
                index = 0;
            showUserData(true);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            mainform.users[index].Blocked = blockBox.Checked;
            mainform.users[index].Restricted = restrictBox.Checked;
        }

        private void showUserForm_Load(object sender, EventArgs e)
        {
            showUserData(true);
        }

        private void showUserData(bool forward)
        {
            if (mainform.users[index].Username == "admin")
                if (forward)
                {
                    index++;
                    if (index >= mainform.users.Length)
                        index = 0;
                }
                else
                {
                    index--;
                    if (index < 0)
                        index = mainform.users.Length - 1;
                }
            User curUser = mainform.users[index];

            uNameBox.Text = curUser.Username;
            blockBox.Checked = curUser.Blocked;
            restrictBox.Checked = curUser.Restricted;
        }
    }
}
