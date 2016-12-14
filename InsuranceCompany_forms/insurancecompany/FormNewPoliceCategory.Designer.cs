namespace InsuranceCompany
{
    partial class FormNewPoliceCategory
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
            this.components = new System.ComponentModel.Container();
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
            this.reisterNewPoliceCategoryBox = new System.Windows.Forms.GroupBox();
            this.policeCategoryName = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.policeCategoryNameInput = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.reisterNewPoliceCategoryBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.reisterNewPoliceCategoryBox);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(744, 642);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 10;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(237, 626);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // registerPolice
            // 
            this.registerPolice.Location = new System.Drawing.Point(4, 550);
            this.registerPolice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registerPolice.Name = "registerPolice";
            this.registerPolice.Size = new System.Drawing.Size(230, 69);
            this.registerPolice.TabIndex = 14;
            this.registerPolice.Text = "Оформление полиса";
            this.registerPolice.UseVisualStyleBackColor = true;
            this.registerPolice.Click += new System.EventHandler(this.registerPolice_Click);
            // 
            // registerNewInsuranceCase
            // 
            this.registerNewInsuranceCase.Location = new System.Drawing.Point(3, 3);
            this.registerNewInsuranceCase.Name = "registerNewInsuranceCase";
            this.registerNewInsuranceCase.Size = new System.Drawing.Size(231, 58);
            this.registerNewInsuranceCase.TabIndex = 0;
            this.registerNewInsuranceCase.Tag = "registerNewInsuranceCase";
            this.registerNewInsuranceCase.Text = "Зарегистрировать новый страховой случай";
            this.registerNewInsuranceCase.UseVisualStyleBackColor = true;
            this.registerNewInsuranceCase.Click += new System.EventHandler(this.registerNewInsuranceCase_Click);
            // 
            // registerClientButton
            // 
            this.registerClientButton.Location = new System.Drawing.Point(4, 485);
            this.registerClientButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registerClientButton.Name = "registerClientButton";
            this.registerClientButton.Size = new System.Drawing.Size(230, 55);
            this.registerClientButton.TabIndex = 13;
            this.registerClientButton.Text = "Зарегистрировать клиента";
            this.registerClientButton.UseVisualStyleBackColor = true;
            this.registerClientButton.Click += new System.EventHandler(this.registerClientButton_Click);
            // 
            // registerNewPoliceCategory
            // 
            this.registerNewPoliceCategory.Location = new System.Drawing.Point(3, 67);
            this.registerNewPoliceCategory.Name = "registerNewPoliceCategory";
            this.registerNewPoliceCategory.Size = new System.Drawing.Size(231, 58);
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
            this.showAllPoliceCategoriesAndCases.Size = new System.Drawing.Size(231, 74);
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
            this.showAllClientsInfo.Size = new System.Drawing.Size(231, 55);
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
            this.showAllClientPayments.Size = new System.Drawing.Size(231, 58);
            this.showAllClientPayments.TabIndex = 3;
            this.showAllClientPayments.Tag = "showAllClientPayments";
            this.showAllClientPayments.Text = "Показать все выплаты клиента";
            this.showAllClientPayments.UseVisualStyleBackColor = true;
            this.showAllClientPayments.Click += new System.EventHandler(this.showAllClientPayments_Click);
            // 
            // formPayment
            // 
            this.formPayment.Location = new System.Drawing.Point(3, 336);
            this.formPayment.Name = "formPayment";
            this.formPayment.Size = new System.Drawing.Size(231, 57);
            this.formPayment.TabIndex = 5;
            this.formPayment.Tag = "formPayment";
            this.formPayment.Text = "Оформить выплату";
            this.formPayment.UseVisualStyleBackColor = true;
            this.formPayment.Click += new System.EventHandler(this.formPayment_Click);
            // 
            // getClientInfo
            // 
            this.getClientInfo.Location = new System.Drawing.Point(3, 399);
            this.getClientInfo.Name = "getClientInfo";
            this.getClientInfo.Size = new System.Drawing.Size(231, 78);
            this.getClientInfo.TabIndex = 6;
            this.getClientInfo.Tag = "getClientInfo";
            this.getClientInfo.Text = "Показать всю информацию по клиенту";
            this.getClientInfo.UseVisualStyleBackColor = true;
            this.getClientInfo.Click += new System.EventHandler(this.getClientInfo_Click);
            // 
            // reisterNewPoliceCategoryBox
            // 
            this.reisterNewPoliceCategoryBox.Controls.Add(this.policeCategoryName);
            this.reisterNewPoliceCategoryBox.Controls.Add(this.submit);
            this.reisterNewPoliceCategoryBox.Controls.Add(this.policeCategoryNameInput);
            this.reisterNewPoliceCategoryBox.Location = new System.Drawing.Point(18, 8);
            this.reisterNewPoliceCategoryBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reisterNewPoliceCategoryBox.Name = "reisterNewPoliceCategoryBox";
            this.reisterNewPoliceCategoryBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reisterNewPoliceCategoryBox.Size = new System.Drawing.Size(441, 217);
            this.reisterNewPoliceCategoryBox.TabIndex = 12;
            this.reisterNewPoliceCategoryBox.TabStop = false;
            this.reisterNewPoliceCategoryBox.Text = "Регистрация новой страховой категории";
            // 
            // policeCategoryName
            // 
            this.policeCategoryName.AutoSize = true;
            this.policeCategoryName.Location = new System.Drawing.Point(64, 43);
            this.policeCategoryName.Name = "policeCategoryName";
            this.policeCategoryName.Size = new System.Drawing.Size(227, 20);
            this.policeCategoryName.TabIndex = 5;
            this.policeCategoryName.Tag = "policeCategoryName";
            this.policeCategoryName.Text = "Название категории полиса:";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(165, 129);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(130, 34);
            this.submit.TabIndex = 9;
            this.submit.Tag = "submit";
            this.submit.Text = "Отправить";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // policeCategoryNameInput
            // 
            this.policeCategoryNameInput.Location = new System.Drawing.Point(69, 71);
            this.policeCategoryNameInput.Name = "policeCategoryNameInput";
            this.policeCategoryNameInput.Size = new System.Drawing.Size(224, 26);
            this.policeCategoryNameInput.TabIndex = 6;
            this.policeCategoryNameInput.TextChanged += new System.EventHandler(this.policeCategoryNameInput_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormNewPoliceCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 668);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormNewPoliceCategory";
            this.Text = "Страховщик: регистрация категории полиса";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.reisterNewPoliceCategoryBox.ResumeLayout(false);
            this.reisterNewPoliceCategoryBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.GroupBox reisterNewPoliceCategoryBox;
        private System.Windows.Forms.Label policeCategoryName;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox policeCategoryNameInput;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button registerPolice;
        private System.Windows.Forms.Button registerClientButton;

    }
}