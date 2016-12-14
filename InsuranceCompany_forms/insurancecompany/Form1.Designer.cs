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
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(798, 49);
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
            this.chooseUser.Size = new System.Drawing.Size(235, 39);
            this.chooseUser.Text = "Выберите пользователя";
            this.chooseUser.Click += new System.EventHandler(this.clientMenu_Click);
            // 
            // clientMenu
            // 
            this.clientMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.legalMenu,
            this.individualMenu});
            this.clientMenu.Name = "clientMenu";
            this.clientMenu.Size = new System.Drawing.Size(198, 30);
            this.clientMenu.Text = "Клиент";
            this.clientMenu.Click += new System.EventHandler(this.clientMenu_Click_1);
            // 
            // legalMenu
            // 
            this.legalMenu.Name = "legalMenu";
            this.legalMenu.Size = new System.Drawing.Size(258, 30);
            this.legalMenu.Text = "Юридическое лицо";
            this.legalMenu.Click += new System.EventHandler(this.legalMenu_Click);
            // 
            // individualMenu
            // 
            this.individualMenu.Name = "individualMenu";
            this.individualMenu.Size = new System.Drawing.Size(258, 30);
            this.individualMenu.Text = "Физическое лицо";
            this.individualMenu.Click += new System.EventHandler(this.individualMenu_Click);
            // 
            // insurerMenu
            // 
            this.insurerMenu.Name = "insurerMenu";
            this.insurerMenu.Size = new System.Drawing.Size(198, 30);
            this.insurerMenu.Text = "Страховщик";
            this.insurerMenu.Click += new System.EventHandler(this.insurerMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Страховая компания";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Страховая компания";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton chooseUser;
        private System.Windows.Forms.ToolStripMenuItem clientMenu;
        private System.Windows.Forms.ToolStripMenuItem legalMenu;
        private System.Windows.Forms.ToolStripMenuItem individualMenu;
        private System.Windows.Forms.ToolStripMenuItem insurerMenu;
        private System.Windows.Forms.Label label1;
    }
}

