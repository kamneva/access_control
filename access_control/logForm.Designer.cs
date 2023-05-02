namespace access_control
{
    partial class logForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.okBut = new System.Windows.Forms.Button();
            this.cancelBut = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.pswd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите логин:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите пароль (при наличии):";
            // 
            // okBut
            // 
            this.okBut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okBut.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBut.Location = new System.Drawing.Point(26, 344);
            this.okBut.Margin = new System.Windows.Forms.Padding(6);
            this.okBut.Name = "okBut";
            this.okBut.Size = new System.Drawing.Size(162, 46);
            this.okBut.TabIndex = 2;
            this.okBut.Text = "ОК";
            this.okBut.UseVisualStyleBackColor = true;
            this.okBut.Click += new System.EventHandler(this.okBut_Click);
            // 
            // cancelBut
            // 
            this.cancelBut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelBut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBut.Location = new System.Drawing.Point(422, 344);
            this.cancelBut.Margin = new System.Windows.Forms.Padding(6);
            this.cancelBut.Name = "cancelBut";
            this.cancelBut.Size = new System.Drawing.Size(162, 46);
            this.cancelBut.TabIndex = 3;
            this.cancelBut.Text = "Отмена";
            this.cancelBut.UseVisualStyleBackColor = true;
            this.cancelBut.Click += new System.EventHandler(this.cancelBut_Click);
            // 
            // login
            // 
            this.login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login.Location = new System.Drawing.Point(26, 101);
            this.login.Margin = new System.Windows.Forms.Padding(6);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(558, 34);
            this.login.TabIndex = 4;
            // 
            // pswd
            // 
            this.pswd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pswd.Location = new System.Drawing.Point(26, 250);
            this.pswd.Margin = new System.Windows.Forms.Padding(6);
            this.pswd.Name = "pswd";
            this.pswd.PasswordChar = '*';
            this.pswd.Size = new System.Drawing.Size(558, 34);
            this.pswd.TabIndex = 5;
            this.pswd.TextChanged += new System.EventHandler(this.pswd_TextChanged);
            // 
            // logForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 523);
            this.Controls.Add(this.pswd);
            this.Controls.Add(this.login);
            this.Controls.Add(this.cancelBut);
            this.Controls.Add(this.okBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "logForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в систему";
            this.Load += new System.EventHandler(this.logForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button okBut;
        private System.Windows.Forms.Button cancelBut;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox pswd;
    }
}