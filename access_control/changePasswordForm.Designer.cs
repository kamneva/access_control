namespace access_control
{
    partial class changePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changePasswordForm));
            this.verify = new System.Windows.Forms.TextBox();
            this.newPass = new System.Windows.Forms.TextBox();
            this.cancelBut = new System.Windows.Forms.Button();
            this.okBut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.oldPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // verify
            // 
            this.verify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.verify.Location = new System.Drawing.Point(26, 382);
            this.verify.Margin = new System.Windows.Forms.Padding(6);
            this.verify.Name = "verify";
            this.verify.PasswordChar = '*';
            this.verify.Size = new System.Drawing.Size(558, 34);
            this.verify.TabIndex = 11;
            // 
            // newPass
            // 
            this.newPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newPass.Location = new System.Drawing.Point(26, 232);
            this.newPass.Margin = new System.Windows.Forms.Padding(6);
            this.newPass.Name = "newPass";
            this.newPass.PasswordChar = '*';
            this.newPass.Size = new System.Drawing.Size(558, 34);
            this.newPass.TabIndex = 10;
            this.newPass.TextChanged += new System.EventHandler(this.newPass_TextChanged);
            // 
            // cancelBut
            // 
            this.cancelBut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelBut.Location = new System.Drawing.Point(422, 466);
            this.cancelBut.Margin = new System.Windows.Forms.Padding(6);
            this.cancelBut.Name = "cancelBut";
            this.cancelBut.Size = new System.Drawing.Size(162, 46);
            this.cancelBut.TabIndex = 9;
            this.cancelBut.Text = "Отмена";
            this.cancelBut.UseVisualStyleBackColor = true;
            this.cancelBut.Click += new System.EventHandler(this.cancelBut_Click);
            // 
            // okBut
            // 
            this.okBut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okBut.Location = new System.Drawing.Point(26, 466);
            this.okBut.Margin = new System.Windows.Forms.Padding(6);
            this.okBut.Name = "okBut";
            this.okBut.Size = new System.Drawing.Size(162, 46);
            this.okBut.TabIndex = 8;
            this.okBut.Text = "ОК";
            this.okBut.UseVisualStyleBackColor = true;
            this.okBut.Click += new System.EventHandler(this.okBut_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 325);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Повторите пароль";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Новый пароль";
            // 
            // oldPass
            // 
            this.oldPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oldPass.Location = new System.Drawing.Point(26, 101);
            this.oldPass.Margin = new System.Windows.Forms.Padding(6);
            this.oldPass.Name = "oldPass";
            this.oldPass.PasswordChar = '*';
            this.oldPass.Size = new System.Drawing.Size(558, 34);
            this.oldPass.TabIndex = 13;
            this.oldPass.TextChanged += new System.EventHandler(this.oldPass_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Старый пароль";
            // 
            // changePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 544);
            this.Controls.Add(this.oldPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.verify);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.cancelBut);
            this.Controls.Add(this.okBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "changePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сменить пароль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox verify;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.Button cancelBut;
        private System.Windows.Forms.Button okBut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oldPass;
        private System.Windows.Forms.Label label3;
    }
}