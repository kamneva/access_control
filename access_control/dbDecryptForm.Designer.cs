namespace access_control
{
    partial class dbDecryptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dbDecryptForm));
            this.label1 = new System.Windows.Forms.Label();
            this.hashPswdBox = new System.Windows.Forms.TextBox();
            this.okBut = new System.Windows.Forms.Button();
            this.cancelBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(82, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пароль для расшифровки базы данных:";
            // 
            // hashPswdBox
            // 
            this.hashPswdBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hashPswdBox.Location = new System.Drawing.Point(87, 90);
            this.hashPswdBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.hashPswdBox.Name = "hashPswdBox";
            this.hashPswdBox.PasswordChar = '*';
            this.hashPswdBox.Size = new System.Drawing.Size(437, 34);
            this.hashPswdBox.TabIndex = 1;
            this.hashPswdBox.TextChanged += new System.EventHandler(this.hashPswdBox_TextChanged);
            // 
            // okBut
            // 
            this.okBut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okBut.Location = new System.Drawing.Point(87, 160);
            this.okBut.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.okBut.Name = "okBut";
            this.okBut.Size = new System.Drawing.Size(123, 56);
            this.okBut.TabIndex = 2;
            this.okBut.Text = "ОК";
            this.okBut.UseVisualStyleBackColor = true;
            this.okBut.Click += new System.EventHandler(this.okBut_Click);
            // 
            // cancelBut
            // 
            this.cancelBut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelBut.Location = new System.Drawing.Point(382, 160);
            this.cancelBut.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cancelBut.Name = "cancelBut";
            this.cancelBut.Size = new System.Drawing.Size(142, 56);
            this.cancelBut.TabIndex = 3;
            this.cancelBut.Text = "Отмена";
            this.cancelBut.UseVisualStyleBackColor = true;
            this.cancelBut.Click += new System.EventHandler(this.cancelBut_Click);
            // 
            // dbDecryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(624, 234);
            this.Controls.Add(this.cancelBut);
            this.Controls.Add(this.okBut);
            this.Controls.Add(this.hashPswdBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "dbDecryptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расшифровка базы данных";
            this.Load += new System.EventHandler(this.dbDecryptForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hashPswdBox;
        private System.Windows.Forms.Button okBut;
        private System.Windows.Forms.Button cancelBut;
    }
}