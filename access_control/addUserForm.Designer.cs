namespace access_control
{
    partial class addUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addUserForm));
            this.label1 = new System.Windows.Forms.Label();
            this.newUserBox = new System.Windows.Forms.TextBox();
            this.cancelBut = new System.Windows.Forms.Button();
            this.okBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя нового пользователя:";
            // 
            // newUserBox
            // 
            this.newUserBox.Location = new System.Drawing.Point(26, 102);
            this.newUserBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.newUserBox.Name = "newUserBox";
            this.newUserBox.Size = new System.Drawing.Size(558, 34);
            this.newUserBox.TabIndex = 1;
            // 
            // cancelBut
            // 
            this.cancelBut.Location = new System.Drawing.Point(422, 188);
            this.cancelBut.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cancelBut.Name = "cancelBut";
            this.cancelBut.Size = new System.Drawing.Size(162, 46);
            this.cancelBut.TabIndex = 11;
            this.cancelBut.Text = "Отмена";
            this.cancelBut.UseVisualStyleBackColor = true;
            this.cancelBut.Click += new System.EventHandler(this.cancelBut_Click);
            // 
            // okBut
            // 
            this.okBut.Location = new System.Drawing.Point(26, 188);
            this.okBut.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.okBut.Name = "okBut";
            this.okBut.Size = new System.Drawing.Size(162, 46);
            this.okBut.TabIndex = 10;
            this.okBut.Text = "ОК";
            this.okBut.UseVisualStyleBackColor = true;
            this.okBut.Click += new System.EventHandler(this.okBut_Click);
            // 
            // addUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 275);
            this.Controls.Add(this.cancelBut);
            this.Controls.Add(this.okBut);
            this.Controls.Add(this.newUserBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "addUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newUserBox;
        private System.Windows.Forms.Button cancelBut;
        private System.Windows.Forms.Button okBut;
    }
}