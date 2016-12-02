namespace InsuranceCompany
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
            this.client = new System.Windows.Forms.Button();
            this.insurer = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.chooseUser = new System.Windows.Forms.ToolStripDropDownButton();
            this.clientMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.legalMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.individualMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.insurerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // client
            // 
            this.client.Location = new System.Drawing.Point(104, 67);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(300, 80);
            this.client.TabIndex = 0;
            this.client.Tag = "client";
            this.client.Text = "Client";
            this.client.UseVisualStyleBackColor = true;
            this.client.Click += new System.EventHandler(this.client_Click);
            // 
            // insurer
            // 
            this.insurer.Location = new System.Drawing.Point(104, 186);
            this.insurer.Name = "insurer";
            this.insurer.Size = new System.Drawing.Size(300, 80);
            this.insurer.TabIndex = 1;
            this.insurer.Tag = "insurer";
            this.insurer.Text = "Insurer";
            this.insurer.UseVisualStyleBackColor = true;
            this.insurer.Click += new System.EventHandler(this.insurer_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(532, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // chooseUser
            // 
            this.chooseUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.chooseUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientMenu,
            this.insurerMenu});
            this.chooseUser.Image = ((System.Drawing.Image)(resources.GetObject("chooseUser.Image")));
            this.chooseUser.ImageTransparentColor = System.Drawing.Color.Gold;
            this.chooseUser.Margin = new System.Windows.Forms.Padding(5);
            this.chooseUser.Name = "chooseUser";
            this.chooseUser.Padding = new System.Windows.Forms.Padding(5);
            this.chooseUser.Size = new System.Drawing.Size(162, 29);
            this.chooseUser.Text = "Выберите пользователя";
            this.chooseUser.Click += new System.EventHandler(this.clientMenu_Click);
            // 
            // clientMenu
            // 
            this.clientMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.legalMenu,
            this.individualMenu});
            this.clientMenu.Name = "clientMenu";
            this.clientMenu.Size = new System.Drawing.Size(142, 22);
            this.clientMenu.Text = "Клиент";
            this.clientMenu.Click += new System.EventHandler(this.clientMenu_Click_1);
            // 
            // legalMenu
            // 
            this.legalMenu.Name = "legalMenu";
            this.legalMenu.Size = new System.Drawing.Size(182, 22);
            this.legalMenu.Text = "Юридическое лицо";
            this.legalMenu.Click += new System.EventHandler(this.legalMenu_Click);
            // 
            // individualMenu
            // 
            this.individualMenu.Name = "individualMenu";
            this.individualMenu.Size = new System.Drawing.Size(182, 22);
            this.individualMenu.Text = "Физическое лицо";
            // 
            // insurerMenu
            // 
            this.insurerMenu.Name = "insurerMenu";
            this.insurerMenu.Size = new System.Drawing.Size(142, 22);
            this.insurerMenu.Text = "Страховщик";
            this.insurerMenu.Click += new System.EventHandler(this.insurerMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Страховая компания";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 351);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.insurer);
            this.Controls.Add(this.client);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button client;
        private System.Windows.Forms.Button insurer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton chooseUser;
        private System.Windows.Forms.ToolStripMenuItem clientMenu;
        private System.Windows.Forms.ToolStripMenuItem legalMenu;
        private System.Windows.Forms.ToolStripMenuItem individualMenu;
        private System.Windows.Forms.ToolStripMenuItem insurerMenu;
        private System.Windows.Forms.Label label1;
    }
}

