namespace InsuranceCompany
{
    partial class FormPaymentRequest
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
            this.clientName = new System.Windows.Forms.TextBox();
            this.clientSurname = new System.Windows.Forms.TextBox();
            this.clientSecondName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.secondName = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.policeNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.policeCase = new System.Windows.Forms.TextBox();
            this.submitPaymentRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientName
            // 
            this.clientName.Location = new System.Drawing.Point(580, 127);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(100, 26);
            this.clientName.TabIndex = 0;
            this.clientName.Tag = "clientName";
            // 
            // clientSurname
            // 
            this.clientSurname.Location = new System.Drawing.Point(580, 218);
            this.clientSurname.Name = "clientSurname";
            this.clientSurname.Size = new System.Drawing.Size(100, 26);
            this.clientSurname.TabIndex = 1;
            this.clientSurname.Tag = "clientSurname";
            // 
            // clientSecondName
            // 
            this.clientSecondName.Location = new System.Drawing.Point(580, 173);
            this.clientSecondName.Name = "clientSecondName";
            this.clientSecondName.Size = new System.Drawing.Size(100, 26);
            this.clientSecondName.TabIndex = 2;
            this.clientSecondName.Tag = "clientSecondName";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(501, 130);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(55, 20);
            this.name.TabIndex = 3;
            this.name.Text = "Name:";
            // 
            // secondName
            // 
            this.secondName.AutoSize = true;
            this.secondName.Location = new System.Drawing.Point(463, 176);
            this.secondName.Name = "secondName";
            this.secondName.Size = new System.Drawing.Size(112, 20);
            this.secondName.TabIndex = 4;
            this.secondName.Text = "Second name:";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(487, 221);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(78, 20);
            this.surname.TabIndex = 5;
            this.surname.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Police number:";
            // 
            // policeNumber
            // 
            this.policeNumber.Location = new System.Drawing.Point(580, 271);
            this.policeNumber.Name = "policeNumber";
            this.policeNumber.Size = new System.Drawing.Size(100, 26);
            this.policeNumber.TabIndex = 7;
            this.policeNumber.Tag = "policeNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Police case:";
            // 
            // policeCase
            // 
            this.policeCase.Location = new System.Drawing.Point(580, 321);
            this.policeCase.Name = "policeCase";
            this.policeCase.Size = new System.Drawing.Size(100, 26);
            this.policeCase.TabIndex = 9;
            this.policeCase.Tag = "policeCase";
            // 
            // submitPaymentRequest
            // 
            this.submitPaymentRequest.Location = new System.Drawing.Point(605, 379);
            this.submitPaymentRequest.Name = "submitPaymentRequest";
            this.submitPaymentRequest.Size = new System.Drawing.Size(75, 23);
            this.submitPaymentRequest.TabIndex = 10;
            this.submitPaymentRequest.Tag = "submitPaymentRequest";
            this.submitPaymentRequest.Text = "Submit";
            this.submitPaymentRequest.UseVisualStyleBackColor = true;
            // 
            // FormPaymentRequest
            // 
            this.ClientSize = new System.Drawing.Size(1378, 844);
            this.Controls.Add(this.submitPaymentRequest);
            this.Controls.Add(this.policeCase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.policeNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.secondName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.clientSecondName);
            this.Controls.Add(this.clientSurname);
            this.Controls.Add(this.clientName);
            this.Name = "FormPaymentRequest";
            this.Text = "Form payment request";
            this.Load += new System.EventHandler(this.FormPaymentRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox clientName;
        private System.Windows.Forms.TextBox clientSurname;
        private System.Windows.Forms.TextBox clientSecondName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label secondName;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox policeNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox policeCase;
        private System.Windows.Forms.Button submitPaymentRequest;
    }
}