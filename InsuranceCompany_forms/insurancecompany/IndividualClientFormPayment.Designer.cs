﻿namespace InsuranceCompany
{
    partial class IndividualClientFormPayment
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
            this.getClientInfo = new System.Windows.Forms.Button();
            this.formPaymentRequest = new System.Windows.Forms.Button();
            this.groupBoxFormPayment = new System.Windows.Forms.GroupBox();
            this.insuranseCaseInput = new System.Windows.Forms.ComboBox();
            this.policeNumberInput = new System.Windows.Forms.TextBox();
            this.submitPaymentRequest = new System.Windows.Forms.Button();
            this.policeNumber = new System.Windows.Forms.Label();
            this.InsuranseCase = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxFormPayment.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxFormPayment);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(480, 305);
            this.splitContainer1.SplitterDistance = 158;
            this.splitContainer1.TabIndex = 12;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(151, 98);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // getClientInfo
            // 
            this.getClientInfo.Location = new System.Drawing.Point(3, 3);
            this.getClientInfo.Name = "getClientInfo";
            this.getClientInfo.Size = new System.Drawing.Size(145, 43);
            this.getClientInfo.TabIndex = 0;
            this.getClientInfo.Tag = "getClientInfo";
            this.getClientInfo.Text = "Показать всю информацию по клиенту";
            this.getClientInfo.UseVisualStyleBackColor = true;
            this.getClientInfo.Click += new System.EventHandler(this.getClientInfo_Click);
            // 
            // formPaymentRequest
            // 
            this.formPaymentRequest.Location = new System.Drawing.Point(3, 52);
            this.formPaymentRequest.Name = "formPaymentRequest";
            this.formPaymentRequest.Size = new System.Drawing.Size(145, 41);
            this.formPaymentRequest.TabIndex = 2;
            this.formPaymentRequest.Tag = "formPaymentRequest";
            this.formPaymentRequest.Text = "Оформить обращение за выплатой";
            this.formPaymentRequest.UseVisualStyleBackColor = true;
            this.formPaymentRequest.Click += new System.EventHandler(this.formPaymentRequest_Click);
            // 
            // groupBoxFormPayment
            // 
            this.groupBoxFormPayment.Controls.Add(this.label1);
            this.groupBoxFormPayment.Controls.Add(this.insuranseCaseInput);
            this.groupBoxFormPayment.Controls.Add(this.policeNumberInput);
            this.groupBoxFormPayment.Controls.Add(this.submitPaymentRequest);
            this.groupBoxFormPayment.Controls.Add(this.policeNumber);
            this.groupBoxFormPayment.Controls.Add(this.InsuranseCase);
            this.groupBoxFormPayment.Location = new System.Drawing.Point(20, 22);
            this.groupBoxFormPayment.Name = "groupBoxFormPayment";
            this.groupBoxFormPayment.Size = new System.Drawing.Size(278, 191);
            this.groupBoxFormPayment.TabIndex = 0;
            this.groupBoxFormPayment.TabStop = false;
            this.groupBoxFormPayment.Text = "Обращение за выплатой";
            this.groupBoxFormPayment.Enter += new System.EventHandler(this.groupBoxFormPayment_Enter);
            // 
            // insuranseCaseInput
            // 
            this.insuranseCaseInput.FormattingEnabled = true;
            this.insuranseCaseInput.Location = new System.Drawing.Point(145, 84);
            this.insuranseCaseInput.Name = "insuranseCaseInput";
            this.insuranseCaseInput.Size = new System.Drawing.Size(100, 21);
            this.insuranseCaseInput.TabIndex = 11;
            this.insuranseCaseInput.SelectedIndexChanged += new System.EventHandler(this.insuranseCaseInput_SelectedIndexChanged);
            // 
            // policeNumberInput
            // 
            this.policeNumberInput.Location = new System.Drawing.Point(145, 44);
            this.policeNumberInput.Name = "policeNumberInput";
            this.policeNumberInput.Size = new System.Drawing.Size(100, 20);
            this.policeNumberInput.TabIndex = 7;
            this.policeNumberInput.Tag = "policeNumber";
            this.policeNumberInput.TextChanged += new System.EventHandler(this.policeNumberInput_TextChanged);
            // 
            // submitPaymentRequest
            // 
            this.submitPaymentRequest.Location = new System.Drawing.Point(170, 120);
            this.submitPaymentRequest.Name = "submitPaymentRequest";
            this.submitPaymentRequest.Size = new System.Drawing.Size(75, 23);
            this.submitPaymentRequest.TabIndex = 10;
            this.submitPaymentRequest.Tag = "submitPaymentRequest";
            this.submitPaymentRequest.Text = "Оформить";
            this.submitPaymentRequest.UseVisualStyleBackColor = true;
            this.submitPaymentRequest.Click += new System.EventHandler(this.submitPaymentRequest_Click);
            // 
            // policeNumber
            // 
            this.policeNumber.AutoSize = true;
            this.policeNumber.Location = new System.Drawing.Point(27, 47);
            this.policeNumber.Name = "policeNumber";
            this.policeNumber.Size = new System.Drawing.Size(98, 13);
            this.policeNumber.TabIndex = 6;
            this.policeNumber.Text = "Страховой номер:";
            // 
            // InsuranseCase
            // 
            this.InsuranseCase.AutoSize = true;
            this.InsuranseCase.Location = new System.Drawing.Point(27, 87);
            this.InsuranseCase.Name = "InsuranseCase";
            this.InsuranseCase.Size = new System.Drawing.Size(100, 13);
            this.InsuranseCase.TabIndex = 8;
            this.InsuranseCase.Text = "Страховой случай:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // IndividualClientFormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 328);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IndividualClientFormPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Физ. лицо: оформление обращения за выплатой";
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

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button getClientInfo;
        private System.Windows.Forms.Button formPaymentRequest;
        private System.Windows.Forms.GroupBox groupBoxFormPayment;
        private System.Windows.Forms.ComboBox insuranseCaseInput;
        private System.Windows.Forms.TextBox policeNumberInput;
        private System.Windows.Forms.Button submitPaymentRequest;
        private System.Windows.Forms.Label policeNumber;
        private System.Windows.Forms.Label InsuranseCase;
        private System.Windows.Forms.Label label1;
    }
}