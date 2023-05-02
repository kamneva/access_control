using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace access_control
{
    public partial class dbDecryptForm : Form
    {
        public Form1 mainform;
        private byte[] trueKey;
        public byte[] enteredKey;
       
        

        public dbDecryptForm(Form1 main, byte[] key)
        {
            InitializeComponent();
            mainform = main;
            trueKey = key;
        }

        private void okBut_Click(object sender, EventArgs e)
        {
            SHA256 hashAlg = SHA256.Create();
            byte[] enteredBytes = Encoding.GetEncoding("windows-1251").GetBytes(hashPswdBox.Text);
            enteredKey = hashAlg.ComputeHash(enteredBytes);
            if (trueKey == null)
            { 

                trueKey = enteredKey;
                this.DialogResult = DialogResult.OK;
               
    }
            else
            {
                if (Encoding.GetEncoding(1251).GetString(trueKey) != Encoding.GetEncoding(1251).GetString(enteredKey))
                {
                    MessageBox.Show("Неправильный пароль для расшифровки базы данных!");
                    this.DialogResult = DialogResult.Abort;
                }

                else
                {  
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void cancelBut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        private void hashPswdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dbDecryptForm_Load(object sender, EventArgs e)
        {

        }
    }
}
