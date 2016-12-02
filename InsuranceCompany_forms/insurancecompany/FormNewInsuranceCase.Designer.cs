namespace InsuranceCompany
{
    partial class FormNewInsuranceCase
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
            this.registerNewInsuranceCase = new System.Windows.Forms.Button();
            this.registerNewPoliceCategory = new System.Windows.Forms.Button();
            this.showAllPoliceCategoriesAndCases = new System.Windows.Forms.Button();
            this.showAllClientsInfo = new System.Windows.Forms.Button();
            this.showAllClientPayments = new System.Windows.Forms.Button();
            this.formPayment = new System.Windows.Forms.Button();
            this.getClientInfo = new System.Windows.Forms.Button();
            this.reisterNewInsuranseCaseBox = new System.Windows.Forms.GroupBox();
            this.insuranceCaseName = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.insuranceCaseNameInput = new System.Windows.Forms.TextBox();
            this.paymentProcentInput = new System.Windows.Forms.NumericUpDown();
            this.paymentProcent = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.reisterNewInsuranseCaseBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentProcentInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reisterNewInsuranseCaseBox);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(456, 315);
            this.splitContainer1.SplitterDistance = 151;
            this.splitContainer1.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.registerNewInsuranceCase, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.registerNewPoliceCategory, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.showAllPoliceCategoriesAndCases, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.showAllClientsInfo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.showAllClientPayments, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.formPayment, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.getClientInfo, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(147, 309);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // registerNewInsuranceCase
            // 
            this.registerNewInsuranceCase.Location = new System.Drawing.Point(2, 2);
            this.registerNewInsuranceCase.Margin = new System.Windows.Forms.Padding(2);
            this.registerNewInsuranceCase.Name = "registerNewInsuranceCase";
            this.registerNewInsuranceCase.Size = new System.Drawing.Size(145, 38);
            this.registerNewInsuranceCase.TabIndex = 0;
            this.registerNewInsuranceCase.Tag = "registerNewInsuranceCase";
            this.registerNewInsuranceCase.Text = "Зарегистрировать новый страховой случай";
            this.registerNewInsuranceCase.UseVisualStyleBackColor = true;
            this.registerNewInsuranceCase.Click += new System.EventHandler(this.registerNewInsuranceCase_Click);
            // 
            // registerNewPoliceCategory
            // 
            this.registerNewPoliceCategory.Location = new System.Drawing.Point(2, 44);
            this.registerNewPoliceCategory.Margin = new System.Windows.Forms.Padding(2);
            this.registerNewPoliceCategory.Name = "registerNewPoliceCategory";
            this.registerNewPoliceCategory.Size = new System.Drawing.Size(145, 38);
            this.registerNewPoliceCategory.TabIndex = 1;
            this.registerNewPoliceCategory.Tag = "registerNewPoliceCategory";
            this.registerNewPoliceCategory.Text = "Зарегистрировать новую категорию полиса";
            this.registerNewPoliceCategory.UseVisualStyleBackColor = true;
            this.registerNewPoliceCategory.Click += new System.EventHandler(this.registerNewPoliceCategory_Click);
            // 
            // showAllPoliceCategoriesAndCases
            // 
            this.showAllPoliceCategoriesAndCases.Location = new System.Drawing.Point(2, 168);
            this.showAllPoliceCategoriesAndCases.Margin = new System.Windows.Forms.Padding(2);
            this.showAllPoliceCategoriesAndCases.Name = "showAllPoliceCategoriesAndCases";
            this.showAllPoliceCategoriesAndCases.Size = new System.Drawing.Size(145, 51);
            this.showAllPoliceCategoriesAndCases.TabIndex = 4;
            this.showAllPoliceCategoriesAndCases.Tag = "showAllPoliceCategoriesAndCases";
            this.showAllPoliceCategoriesAndCases.Text = "Показать все категории полисов и их страховые случаи";
            this.showAllPoliceCategoriesAndCases.UseVisualStyleBackColor = true;
            this.showAllPoliceCategoriesAndCases.Click += new System.EventHandler(this.showAllPoliceCategoriesAndCases_Click);
            // 
            // showAllClientsInfo
            // 
            this.showAllClientsInfo.Location = new System.Drawing.Point(2, 86);
            this.showAllClientsInfo.Margin = new System.Windows.Forms.Padding(2);
            this.showAllClientsInfo.Name = "showAllClientsInfo";
            this.showAllClientsInfo.Size = new System.Drawing.Size(145, 36);
            this.showAllClientsInfo.TabIndex = 2;
            this.showAllClientsInfo.Tag = "showAllClientsInfo";
            this.showAllClientsInfo.Text = "Показать информацию о клиентах и их полисах";
            this.showAllClientsInfo.UseVisualStyleBackColor = true;
            this.showAllClientsInfo.Click += new System.EventHandler(this.showAllClientsInfo_Click);
            // 
            // showAllClientPayments
            // 
            this.showAllClientPayments.Location = new System.Drawing.Point(2, 126);
            this.showAllClientPayments.Margin = new System.Windows.Forms.Padding(2);
            this.showAllClientPayments.Name = "showAllClientPayments";
            this.showAllClientPayments.Size = new System.Drawing.Size(145, 38);
            this.showAllClientPayments.TabIndex = 3;
            this.showAllClientPayments.Tag = "showAllClientPayments";
            this.showAllClientPayments.Text = "Показать все выплаты клиента";
            this.showAllClientPayments.UseVisualStyleBackColor = true;
            this.showAllClientPayments.Click += new System.EventHandler(this.showAllClientPayments_Click);
            // 
            // formPayment
            // 
            this.formPayment.Location = new System.Drawing.Point(2, 223);
            this.formPayment.Margin = new System.Windows.Forms.Padding(2);
            this.formPayment.Name = "formPayment";
            this.formPayment.Size = new System.Drawing.Size(145, 37);
            this.formPayment.TabIndex = 5;
            this.formPayment.Tag = "formPayment";
            this.formPayment.Text = "Оформить выплату";
            this.formPayment.UseVisualStyleBackColor = true;
            this.formPayment.Click += new System.EventHandler(this.formPayment_Click);
            // 
            // getClientInfo
            // 
            this.getClientInfo.Location = new System.Drawing.Point(2, 264);
            this.getClientInfo.Margin = new System.Windows.Forms.Padding(2);
            this.getClientInfo.Name = "getClientInfo";
            this.getClientInfo.Size = new System.Drawing.Size(145, 45);
            this.getClientInfo.TabIndex = 6;
            this.getClientInfo.Tag = "getClientInfo";
            this.getClientInfo.Text = "Показать всю информацию по клиенту";
            this.getClientInfo.UseVisualStyleBackColor = true;
            this.getClientInfo.Click += new System.EventHandler(this.getClientInfo_Click);
            // 
            // reisterNewInsuranseCaseBox
            // 
            this.reisterNewInsuranseCaseBox.Controls.Add(this.insuranceCaseName);
            this.reisterNewInsuranseCaseBox.Controls.Add(this.submit);
            this.reisterNewInsuranseCaseBox.Controls.Add(this.insuranceCaseNameInput);
            this.reisterNewInsuranseCaseBox.Controls.Add(this.paymentProcentInput);
            this.reisterNewInsuranseCaseBox.Controls.Add(this.paymentProcent);
            this.reisterNewInsuranseCaseBox.Location = new System.Drawing.Point(3, 3);
            this.reisterNewInsuranseCaseBox.Name = "reisterNewInsuranseCaseBox";
            this.reisterNewInsuranseCaseBox.Size = new System.Drawing.Size(294, 141);
            this.reisterNewInsuranseCaseBox.TabIndex = 10;
            this.reisterNewInsuranseCaseBox.TabStop = false;
            this.reisterNewInsuranseCaseBox.Text = "Регистрация нового страхового случая";
            // 
            // insuranceCaseName
            // 
            this.insuranceCaseName.AutoSize = true;
            this.insuranceCaseName.Location = new System.Drawing.Point(19, 25);
            this.insuranceCaseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.insuranceCaseName.Name = "insuranceCaseName";
            this.insuranceCaseName.Size = new System.Drawing.Size(100, 13);
            this.insuranceCaseName.TabIndex = 5;
            this.insuranceCaseName.Tag = "insuranceCaseName";
            this.insuranceCaseName.Text = "Страховой случай:";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(206, 93);
            this.submit.Margin = new System.Windows.Forms.Padding(2);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(59, 22);
            this.submit.TabIndex = 9;
            this.submit.Tag = "submit";
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // insuranceCaseNameInput
            // 
            this.insuranceCaseNameInput.Location = new System.Drawing.Point(134, 23);
            this.insuranceCaseNameInput.Margin = new System.Windows.Forms.Padding(2);
            this.insuranceCaseNameInput.Name = "insuranceCaseNameInput";
            this.insuranceCaseNameInput.Size = new System.Drawing.Size(131, 20);
            this.insuranceCaseNameInput.TabIndex = 6;
            this.insuranceCaseNameInput.TextChanged += new System.EventHandler(this.insuranceCaseNameInput_TextChanged);
            // 
            // paymentProcentInput
            // 
            this.paymentProcentInput.DecimalPlaces = 1;
            this.paymentProcentInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.paymentProcentInput.Location = new System.Drawing.Point(134, 55);
            this.paymentProcentInput.Margin = new System.Windows.Forms.Padding(2);
            this.paymentProcentInput.Name = "paymentProcentInput";
            this.paymentProcentInput.Size = new System.Drawing.Size(131, 20);
            this.paymentProcentInput.TabIndex = 8;
            this.paymentProcentInput.Tag = "paymentProcentNumeric";
            // 
            // paymentProcent
            // 
            this.paymentProcent.AutoSize = true;
            this.paymentProcent.Location = new System.Drawing.Point(19, 55);
            this.paymentProcent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.paymentProcent.Name = "paymentProcent";
            this.paymentProcent.Size = new System.Drawing.Size(101, 13);
            this.paymentProcent.TabIndex = 7;
            this.paymentProcent.Tag = "paymentProcent";
            this.paymentProcent.Text = "Процент выплаты:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this.paymentProcentInput;
            // 
            // FormNewInsuranceCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 333);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormNewInsuranceCase";
            this.Text = "FormNewInsuranceCase";
            this.Load += new System.EventHandler(this.FormNewInsuranceCase_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.reisterNewInsuranseCaseBox.ResumeLayout(false);
            this.reisterNewInsuranseCaseBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentProcentInput)).EndInit();
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
        private System.Windows.Forms.GroupBox reisterNewInsuranseCaseBox;
        private System.Windows.Forms.Label insuranceCaseName;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox insuranceCaseNameInput;
        private System.Windows.Forms.NumericUpDown paymentProcentInput;
        private System.Windows.Forms.Label paymentProcent;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}