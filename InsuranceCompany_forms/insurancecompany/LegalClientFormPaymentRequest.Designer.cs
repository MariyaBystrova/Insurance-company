namespace InsuranceCompany
{
    partial class LegalClientFormPaymentRequest
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
            this.policeNumber = new System.Windows.Forms.Label();
            this.policeNumberInput = new System.Windows.Forms.TextBox();
            this.InsuranseCase = new System.Windows.Forms.Label();
            this.submitPaymentRequest = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.getClientInfo = new System.Windows.Forms.Button();
            this.formPaymentRequest = new System.Windows.Forms.Button();
            this.groupBoxFormPayment = new System.Windows.Forms.GroupBox();
            this.insuranseCaseInput = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxFormPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // policeNumber
            // 
            this.policeNumber.AutoSize = true;
            this.policeNumber.Location = new System.Drawing.Point(27, 36);
            this.policeNumber.Name = "policeNumber";
            this.policeNumber.Size = new System.Drawing.Size(98, 13);
            this.policeNumber.TabIndex = 6;
            this.policeNumber.Text = "Страховой номер:";
            // 
            // policeNumberInput
            // 
            this.policeNumberInput.Location = new System.Drawing.Point(183, 36);
            this.policeNumberInput.Name = "policeNumberInput";
            this.policeNumberInput.Size = new System.Drawing.Size(131, 20);
            this.policeNumberInput.TabIndex = 7;
            this.policeNumberInput.Tag = "policeNumber";
            // 
            // InsuranseCase
            // 
            this.InsuranseCase.AutoSize = true;
            this.InsuranseCase.Location = new System.Drawing.Point(27, 75);
            this.InsuranseCase.Name = "InsuranseCase";
            this.InsuranseCase.Size = new System.Drawing.Size(100, 13);
            this.InsuranseCase.TabIndex = 8;
            this.InsuranseCase.Text = "Страховой случай:";
            // 
            // submitPaymentRequest
            // 
            this.submitPaymentRequest.Location = new System.Drawing.Point(214, 126);
            this.submitPaymentRequest.Name = "submitPaymentRequest";
            this.submitPaymentRequest.Size = new System.Drawing.Size(100, 32);
            this.submitPaymentRequest.TabIndex = 10;
            this.submitPaymentRequest.Tag = "submitPaymentRequest";
            this.submitPaymentRequest.Text = "Оформить";
            this.submitPaymentRequest.UseVisualStyleBackColor = true;
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
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxFormPayment);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(574, 417);
            this.splitContainer1.SplitterDistance = 188;
            this.splitContainer1.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.getClientInfo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.formPaymentRequest, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(181, 153);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // getClientInfo
            // 
            this.getClientInfo.Location = new System.Drawing.Point(3, 3);
            this.getClientInfo.Name = "getClientInfo";
            this.getClientInfo.Size = new System.Drawing.Size(175, 72);
            this.getClientInfo.TabIndex = 0;
            this.getClientInfo.Tag = "getClientInfo";
            this.getClientInfo.Text = "Показать всю информацию по клиенту";
            this.getClientInfo.UseVisualStyleBackColor = true;
            this.getClientInfo.Click += new System.EventHandler(this.getClientInfo_Click);
            // 
            // formPaymentRequest
            // 
            this.formPaymentRequest.Location = new System.Drawing.Point(3, 81);
            this.formPaymentRequest.Name = "formPaymentRequest";
            this.formPaymentRequest.Size = new System.Drawing.Size(175, 68);
            this.formPaymentRequest.TabIndex = 2;
            this.formPaymentRequest.Tag = "formPaymentRequest";
            this.formPaymentRequest.Text = "Оформить обращение за выплатой";
            this.formPaymentRequest.UseVisualStyleBackColor = true;
            this.formPaymentRequest.Click += new System.EventHandler(this.formPaymentRequest_Click);
            // 
            // groupBoxFormPayment
            // 
            this.groupBoxFormPayment.Controls.Add(this.insuranseCaseInput);
            this.groupBoxFormPayment.Controls.Add(this.policeNumberInput);
            this.groupBoxFormPayment.Controls.Add(this.submitPaymentRequest);
            this.groupBoxFormPayment.Controls.Add(this.policeNumber);
            this.groupBoxFormPayment.Controls.Add(this.InsuranseCase);
            this.groupBoxFormPayment.Location = new System.Drawing.Point(20, 22);
            this.groupBoxFormPayment.Name = "groupBoxFormPayment";
            this.groupBoxFormPayment.Size = new System.Drawing.Size(347, 230);
            this.groupBoxFormPayment.TabIndex = 0;
            this.groupBoxFormPayment.TabStop = false;
            this.groupBoxFormPayment.Text = "Обращение за выплатой";
            // 
            // insuranseCaseInput
            // 
            this.insuranseCaseInput.FormattingEnabled = true;
            this.insuranseCaseInput.Location = new System.Drawing.Point(183, 75);
            this.insuranseCaseInput.Name = "insuranseCaseInput";
            this.insuranseCaseInput.Size = new System.Drawing.Size(131, 21);
            this.insuranseCaseInput.TabIndex = 11;
            // 
            // LegalClientFormPaymentRequest
            // 
            this.ClientSize = new System.Drawing.Size(598, 441);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LegalClientFormPaymentRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Юр. лицо: оформление обращения за выплатой";
            this.Load += new System.EventHandler(this.FormPaymentRequest_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxFormPayment.ResumeLayout(false);
            this.groupBoxFormPayment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label policeNumber;
        private System.Windows.Forms.TextBox policeNumberInput;
        private System.Windows.Forms.Label InsuranseCase;
        private System.Windows.Forms.Button submitPaymentRequest;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button getClientInfo;
        private System.Windows.Forms.Button formPaymentRequest;
        private System.Windows.Forms.GroupBox groupBoxFormPayment;
        private System.Windows.Forms.ComboBox insuranseCaseInput;
    }
}