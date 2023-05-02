namespace access_control
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменаПароляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйПользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеПользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(320, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменаПароляToolStripMenuItem,
            this.новыйПользовательToolStripMenuItem,
            this.всеПользователиToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem,
            this.выходToolStripMenuItem1});
            this.пользователиToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(76, 26);
            this.пользователиToolStripMenuItem.Text = "Меню";
            // 
            // сменаПароляToolStripMenuItem
            // 
            this.сменаПароляToolStripMenuItem.Enabled = false;
            this.сменаПароляToolStripMenuItem.Name = "сменаПароляToolStripMenuItem";
            this.сменаПароляToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.сменаПароляToolStripMenuItem.Text = "Смена пароля";
            this.сменаПароляToolStripMenuItem.Click += new System.EventHandler(this.сменаПароляToolStripMenuItem_Click);
            // 
            // новыйПользовательToolStripMenuItem
            // 
            this.новыйПользовательToolStripMenuItem.Enabled = false;
            this.новыйПользовательToolStripMenuItem.Name = "новыйПользовательToolStripMenuItem";
            this.новыйПользовательToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.новыйПользовательToolStripMenuItem.Text = "Новый пользователь";
            this.новыйПользовательToolStripMenuItem.Click += new System.EventHandler(this.новыйПользовательToolStripMenuItem_Click);
            // 
            // всеПользователиToolStripMenuItem
            // 
            this.всеПользователиToolStripMenuItem.Enabled = false;
            this.всеПользователиToolStripMenuItem.Name = "всеПользователиToolStripMenuItem";
            this.всеПользователиToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.всеПользователиToolStripMenuItem.Text = "Все пользователи";
            this.всеПользователиToolStripMenuItem.Click += new System.EventHandler(this.всеПользователиToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(265, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Enabled = false;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.выходToolStripMenuItem.Text = "Выход из системы";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(95, 26);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // LogIn
            // 
            this.LogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogIn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LogIn.Location = new System.Drawing.Point(42, 89);
            this.LogIn.Margin = new System.Windows.Forms.Padding(6);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(236, 70);
            this.LogIn.TabIndex = 1;
            this.LogIn.Text = "Войти в систему";
            this.LogIn.UseVisualStyleBackColor = false;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добро пожаловать!";
            this.label1.Visible = false;
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(268, 26);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(320, 210);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменаПароляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйПользовательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеПользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
    }
}

