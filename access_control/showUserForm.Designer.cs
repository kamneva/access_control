namespace access_control
{
    partial class showUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showUserForm));
            this.blockBox = new System.Windows.Forms.CheckBox();
            this.restrictBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uNameBox = new System.Windows.Forms.TextBox();
            this.Prev = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // blockBox
            // 
            this.blockBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.blockBox.AutoSize = true;
            this.blockBox.Location = new System.Drawing.Point(34, 159);
            this.blockBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.blockBox.Name = "blockBox";
            this.blockBox.Size = new System.Drawing.Size(155, 31);
            this.blockBox.TabIndex = 0;
            this.blockBox.Text = "Блокировка";
            this.blockBox.UseVisualStyleBackColor = true;
            // 
            // restrictBox
            // 
            this.restrictBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.restrictBox.AutoSize = true;
            this.restrictBox.Location = new System.Drawing.Point(34, 203);
            this.restrictBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.restrictBox.Name = "restrictBox";
            this.restrictBox.Size = new System.Drawing.Size(282, 31);
            this.restrictBox.TabIndex = 1;
            this.restrictBox.Text = "Парольное ограничение";
            this.restrictBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя пользователя:";
            // 
            // uNameBox
            // 
            this.uNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uNameBox.Location = new System.Drawing.Point(265, 81);
            this.uNameBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uNameBox.Name = "uNameBox";
            this.uNameBox.ReadOnly = true;
            this.uNameBox.Size = new System.Drawing.Size(286, 34);
            this.uNameBox.TabIndex = 3;
            // 
            // Prev
            // 
            this.Prev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Prev.Location = new System.Drawing.Point(87, 339);
            this.Prev.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(122, 47);
            this.Prev.TabIndex = 4;
            this.Prev.Text = "<<";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // Next
            // 
            this.Next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Next.Location = new System.Drawing.Point(395, 339);
            this.Next.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(122, 47);
            this.Next.TabIndex = 5;
            this.Next.Text = ">>";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Save
            // 
            this.Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Save.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Save.Location = new System.Drawing.Point(228, 275);
            this.Save.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(150, 47);
            this.Save.TabIndex = 6;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit.BackColor = System.Drawing.Color.IndianRed;
            this.Exit.Location = new System.Drawing.Point(454, 432);
            this.Exit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(122, 47);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // showUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 493);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.uNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.restrictBox);
            this.Controls.Add(this.blockBox);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "showUserForm";
            this.Text = "Просмотр пользователей";
            this.Load += new System.EventHandler(this.showUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox blockBox;
        private System.Windows.Forms.CheckBox restrictBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uNameBox;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Exit;
    }
}