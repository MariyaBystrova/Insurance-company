namespace InsuranceCompany
{
    partial class ShowAllClientsPayments
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.registerPolice = new System.Windows.Forms.Button();
            this.registerNewInsuranceCase = new System.Windows.Forms.Button();
            this.registerClientButton = new System.Windows.Forms.Button();
            this.registerNewPoliceCategory = new System.Windows.Forms.Button();
            this.showAllPoliceCategoriesAndCases = new System.Windows.Forms.Button();
            this.showAllClientsInfo = new System.Windows.Forms.Button();
            this.showAllClientPayments = new System.Windows.Forms.Button();
            this.formPayment = new System.Windows.Forms.Button();
            this.getClientInfo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientType = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(18, 18);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.clientType);
            this.splitContainer1.Panel2.Controls.Add(this.name);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(708, 603);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.registerPolice, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.registerNewInsuranceCase, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.registerClientButton, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.registerNewPoliceCategory, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.showAllPoliceCategoriesAndCases, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.showAllClientsInfo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.showAllClientPayments, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.formPayment, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.getClientInfo, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(224, 594);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // registerPolice
            // 
            this.registerPolice.Location = new System.Drawing.Point(4, 530);
            this.registerPolice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registerPolice.Name = "registerPolice";
            this.registerPolice.Size = new System.Drawing.Size(216, 55);
            this.registerPolice.TabIndex = 4;
            this.registerPolice.Text = "Оформление полиса";
            this.registerPolice.UseVisualStyleBackColor = true;
            this.registerPolice.Click += new System.EventHandler(this.registerPolice_Click);
            // 
            // registerNewInsuranceCase
            // 
            this.registerNewInsuranceCase.Location = new System.Drawing.Point(3, 3);
            this.registerNewInsuranceCase.Name = "registerNewInsuranceCase";
            this.registerNewInsuranceCase.Size = new System.Drawing.Size(218, 58);
            this.registerNewInsuranceCase.TabIndex = 0;
            this.registerNewInsuranceCase.Tag = "registerNewInsuranceCase";
            this.registerNewInsuranceCase.Text = "Зарегистрировать новый страховой случай";
            this.registerNewInsuranceCase.UseVisualStyleBackColor = true;
            this.registerNewInsuranceCase.Click += new System.EventHandler(this.registerNewInsuranceCase_Click);
            // 
            // registerClientButton
            // 
            this.registerClientButton.Location = new System.Drawing.Point(4, 465);
            this.registerClientButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registerClientButton.Name = "registerClientButton";
            this.registerClientButton.Size = new System.Drawing.Size(216, 55);
            this.registerClientButton.TabIndex = 3;
            this.registerClientButton.Text = "Зарегистрировать клиента";
            this.registerClientButton.UseVisualStyleBackColor = true;
            this.registerClientButton.Click += new System.EventHandler(this.registerClientButton_Click);
            // 
            // registerNewPoliceCategory
            // 
            this.registerNewPoliceCategory.Location = new System.Drawing.Point(3, 67);
            this.registerNewPoliceCategory.Name = "registerNewPoliceCategory";
            this.registerNewPoliceCategory.Size = new System.Drawing.Size(218, 58);
            this.registerNewPoliceCategory.TabIndex = 1;
            this.registerNewPoliceCategory.Tag = "registerNewPoliceCategory";
            this.registerNewPoliceCategory.Text = "Зарегистрировать новую категорию полиса";
            this.registerNewPoliceCategory.UseVisualStyleBackColor = true;
            this.registerNewPoliceCategory.Click += new System.EventHandler(this.registerNewPoliceCategory_Click);
            // 
            // showAllPoliceCategoriesAndCases
            // 
            this.showAllPoliceCategoriesAndCases.Location = new System.Drawing.Point(3, 256);
            this.showAllPoliceCategoriesAndCases.Name = "showAllPoliceCategoriesAndCases";
            this.showAllPoliceCategoriesAndCases.Size = new System.Drawing.Size(218, 77);
            this.showAllPoliceCategoriesAndCases.TabIndex = 4;
            this.showAllPoliceCategoriesAndCases.Tag = "showAllPoliceCategoriesAndCases";
            this.showAllPoliceCategoriesAndCases.Text = "Показать все категории полисов и их страховые случаи";
            this.showAllPoliceCategoriesAndCases.UseVisualStyleBackColor = true;
            this.showAllPoliceCategoriesAndCases.Click += new System.EventHandler(this.showAllPoliceCategoriesAndCases_Click);
            // 
            // showAllClientsInfo
            // 
            this.showAllClientsInfo.Location = new System.Drawing.Point(3, 131);
            this.showAllClientsInfo.Name = "showAllClientsInfo";
            this.showAllClientsInfo.Size = new System.Drawing.Size(218, 55);
            this.showAllClientsInfo.TabIndex = 2;
            this.showAllClientsInfo.Tag = "showAllClientsInfo";
            this.showAllClientsInfo.Text = "Показать информацию о клиентах и полисах";
            this.showAllClientsInfo.UseVisualStyleBackColor = true;
            this.showAllClientsInfo.Click += new System.EventHandler(this.showAllClientsInfo_Click);
            // 
            // showAllClientPayments
            // 
            this.showAllClientPayments.Location = new System.Drawing.Point(3, 192);
            this.showAllClientPayments.Name = "showAllClientPayments";
            this.showAllClientPayments.Size = new System.Drawing.Size(218, 58);
            this.showAllClientPayments.TabIndex = 3;
            this.showAllClientPayments.Tag = "showAllClientPayments";
            this.showAllClientPayments.Text = "Показать все выплаты клиента";
            this.showAllClientPayments.UseVisualStyleBackColor = true;
            this.showAllClientPayments.Click += new System.EventHandler(this.showAllClientPayments_Click);
            // 
            // formPayment
            // 
            this.formPayment.Location = new System.Drawing.Point(3, 339);
            this.formPayment.Name = "formPayment";
            this.formPayment.Size = new System.Drawing.Size(218, 57);
            this.formPayment.TabIndex = 5;
            this.formPayment.Tag = "formPayment";
            this.formPayment.Text = "Оформить выплату";
            this.formPayment.UseVisualStyleBackColor = true;
            this.formPayment.Click += new System.EventHandler(this.formPayment_Click);
            // 
            // getClientInfo
            // 
            this.getClientInfo.Location = new System.Drawing.Point(3, 402);
            this.getClientInfo.Name = "getClientInfo";
            this.getClientInfo.Size = new System.Drawing.Size(218, 55);
            this.getClientInfo.TabIndex = 6;
            this.getClientInfo.Tag = "getClientInfo";
            this.getClientInfo.Text = "Показать информацию по клиенту";
            this.getClientInfo.UseVisualStyleBackColor = true;
            this.getClientInfo.Click += new System.EventHandler(this.getClientInfo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 51);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(462, 542);
            this.dataGridView1.TabIndex = 2;
            // 
            // clientType
            // 
            this.clientType.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            this.clientType.FormattingEnabled = true;
            this.clientType.Items.AddRange(new object[] {
            "legal client",
            "individual client"});
            this.clientType.Location = new System.Drawing.Point(4, 8);
            this.clientType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clientType.Name = "clientType";
            this.clientType.Size = new System.Drawing.Size(217, 28);
            this.clientType.TabIndex = 1;
            this.clientType.SelectedIndexChanged += new System.EventHandler(this.clientType_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.FormattingEnabled = true;
            this.name.Items.AddRange(new object[] {
            "dsds",
            "sa"});
            this.name.Location = new System.Drawing.Point(232, 8);
            this.name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(234, 28);
            this.name.TabIndex = 0;
            this.name.SelectedIndexChanged += new System.EventHandler(this.name_SelectedIndexChanged);
            // 
            // ShowAllClientsPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 625);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ShowAllClientsPayments";
            this.Text = "Страховщик: выплаты клиента";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button registerNewInsuranceCase;
        private System.Windows.Forms.Button registerNewPoliceCategory;
        private System.Windows.Forms.Button showAllPoliceCategoriesAndCases;
        private System.Windows.Forms.Button showAllClientsInfo;
        private System.Windows.Forms.Button showAllClientPayments;
        private System.Windows.Forms.Button formPayment;
        private System.Windows.Forms.Button getClientInfo;
        private System.Windows.Forms.ComboBox name;
        private System.Windows.Forms.ComboBox clientType;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button registerPolice;
        private System.Windows.Forms.Button registerClientButton;
    }
}