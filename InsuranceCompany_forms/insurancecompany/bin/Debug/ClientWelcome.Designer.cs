namespace InsuranceCompany
{
    partial class ClientWelcome
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
            this.getClientInfo = new System.Windows.Forms.Button();
            this.formNewPolice = new System.Windows.Forms.Button();
            this.formPaymentRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getClientInfo
            // 
            this.getClientInfo.Location = new System.Drawing.Point(475, 143);
            this.getClientInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getClientInfo.Name = "getClientInfo";
            this.getClientInfo.Size = new System.Drawing.Size(346, 105);
            this.getClientInfo.TabIndex = 0;
            this.getClientInfo.Tag = "getClientInfo";
            this.getClientInfo.Text = "Get all documents";
            this.getClientInfo.UseVisualStyleBackColor = true;
            this.getClientInfo.Click += new System.EventHandler(this.getClientInfo_Click);
            // 
            // formNewPolice
            // 
            this.formNewPolice.Location = new System.Drawing.Point(475, 257);
            this.formNewPolice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formNewPolice.Name = "formNewPolice";
            this.formNewPolice.Size = new System.Drawing.Size(346, 95);
            this.formNewPolice.TabIndex = 1;
            this.formNewPolice.Tag = "formNewPolice";
            this.formNewPolice.Text = "Form new police";
            this.formNewPolice.UseVisualStyleBackColor = true;
            this.formNewPolice.Click += new System.EventHandler(this.formNewPolice_Click);
            // 
            // formPaymentRequest
            // 
            this.formPaymentRequest.Location = new System.Drawing.Point(475, 361);
            this.formPaymentRequest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formPaymentRequest.Name = "formPaymentRequest";
            this.formPaymentRequest.Size = new System.Drawing.Size(346, 102);
            this.formPaymentRequest.TabIndex = 2;
            this.formPaymentRequest.Tag = "formPaymentRequest";
            this.formPaymentRequest.Text = "Form a request for payment";
            this.formPaymentRequest.UseVisualStyleBackColor = true;
            this.formPaymentRequest.Click += new System.EventHandler(this.formPaymentRequest_Click);
            // 
            // ClientWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 844);
            this.Controls.Add(this.formPaymentRequest);
            this.Controls.Add(this.formNewPolice);
            this.Controls.Add(this.getClientInfo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClientWelcome";
            this.Text = "ClientWelcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getClientInfo;
        private System.Windows.Forms.Button formNewPolice;
        private System.Windows.Forms.Button formPaymentRequest;
    }
}