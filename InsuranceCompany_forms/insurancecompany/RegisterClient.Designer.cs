namespace InsuranceCompany
{
    partial class RegisterClient
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
            this.registerNewInsuranceCase = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.formPolice = new System.Windows.Forms.Button();
            this.registerClientButton = new System.Windows.Forms.Button();
            this.showAllPoliceCategoriesAndCases = new System.Windows.Forms.Button();
            this.showAllClientsInfo = new System.Windows.Forms.Button();
            this.showAllClientPayments = new System.Windows.Forms.Button();
            this.formPayment = new System.Windows.Forms.Button();
            this.getClientInfo = new System.Windows.Forms.Button();
            this.registerNewPoliceCategory = new System.Windows.Forms.Button();
            this.groupBoxIndividual = new System.Windows.Forms.GroupBox();
            this.picturePathInput = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.userDrivingExperience = new System.Windows.Forms.NumericUpDown();
            this.submitIndividual = new System.Windows.Forms.Button();
            this.dateOfBirth = new System.Windows.Forms.Label();
            this.userPhoneNumber = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.Label();
            this.userAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.clientName = new System.Windows.Forms.TextBox();
            this.secondName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.clientSurname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.clientSecondName = new System.Windows.Forms.TextBox();
            this.clientType = new System.Windows.Forms.ComboBox();
            this.groupBoxLegal = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.submitLegalPerson = new System.Windows.Forms.Button();
            this.companyPhoneNumber = new System.Windows.Forms.TextBox();
            this.companyAddress = new System.Windows.Forms.TextBox();
            this.accountantName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.taxUniqueNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.directorName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.companyName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxIndividual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDrivingExperience)).BeginInit();
            this.groupBoxLegal.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.registerNewInsuranceCase);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.clientType);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxLegal);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(720, 606);
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 10;
            // 
            // registerNewInsuranceCase
            // 
            this.registerNewInsuranceCase.Location = new System.Drawing.Point(4, 3);
            this.registerNewInsuranceCase.Name = "registerNewInsuranceCase";
            this.registerNewInsuranceCase.Size = new System.Drawing.Size(220, 72);
            this.registerNewInsuranceCase.TabIndex = 9;
            this.registerNewInsuranceCase.Tag = "registerNewInsuranceCase";
            this.registerNewInsuranceCase.Text = "Зарегистрировать новый страховой случай";
            this.registerNewInsuranceCase.UseVisualStyleBackColor = true;
            this.registerNewInsuranceCase.Click += new System.EventHandler(this.registerNewInsuranceCase_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.formPolice, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.registerClientButton, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.showAllPoliceCategoriesAndCases, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.showAllClientsInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.showAllClientPayments, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.formPayment, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.getClientInfo, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.registerNewPoliceCategory, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 78);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(228, 528);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // formPolice
            // 
            this.formPolice.Location = new System.Drawing.Point(4, 463);
            this.formPolice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formPolice.Name = "formPolice";
            this.formPolice.Size = new System.Drawing.Size(216, 55);
            this.formPolice.TabIndex = 2;
            this.formPolice.Text = "Оформление полиса";
            this.formPolice.UseVisualStyleBackColor = true;
            this.formPolice.Click += new System.EventHandler(this.formPolice_Click);
            // 
            // registerClientButton
            // 
            this.registerClientButton.Location = new System.Drawing.Point(4, 399);
            this.registerClientButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registerClientButton.Name = "registerClientButton";
            this.registerClientButton.Size = new System.Drawing.Size(216, 54);
            this.registerClientButton.TabIndex = 1;
            this.registerClientButton.Text = "Зарегистрировать клиента";
            this.registerClientButton.UseVisualStyleBackColor = true;
            this.registerClientButton.Click += new System.EventHandler(this.registerClientButton_Click);
            // 
            // showAllPoliceCategoriesAndCases
            // 
            this.showAllPoliceCategoriesAndCases.Location = new System.Drawing.Point(3, 192);
            this.showAllPoliceCategoriesAndCases.Name = "showAllPoliceCategoriesAndCases";
            this.showAllPoliceCategoriesAndCases.Size = new System.Drawing.Size(218, 75);
            this.showAllPoliceCategoriesAndCases.TabIndex = 4;
            this.showAllPoliceCategoriesAndCases.Tag = "showAllPoliceCategoriesAndCases";
            this.showAllPoliceCategoriesAndCases.Text = "Показать все категории полисаов и их страховые случаи";
            this.showAllPoliceCategoriesAndCases.UseVisualStyleBackColor = true;
            this.showAllPoliceCategoriesAndCases.Click += new System.EventHandler(this.showAllPoliceCategoriesAndCases_Click);
            // 
            // showAllClientsInfo
            // 
            this.showAllClientsInfo.Location = new System.Drawing.Point(3, 67);
            this.showAllClientsInfo.Name = "showAllClientsInfo";
            this.showAllClientsInfo.Size = new System.Drawing.Size(218, 55);
            this.showAllClientsInfo.TabIndex = 2;
            this.showAllClientsInfo.Tag = "showAllClientsInfo";
            this.showAllClientsInfo.Text = "Показать всю информацию о клиентах и полисах";
            this.showAllClientsInfo.UseVisualStyleBackColor = true;
            this.showAllClientsInfo.Click += new System.EventHandler(this.showAllClientsInfo_Click);
            // 
            // showAllClientPayments
            // 
            this.showAllClientPayments.Location = new System.Drawing.Point(3, 128);
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
            this.formPayment.Location = new System.Drawing.Point(3, 273);
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
            this.getClientInfo.Location = new System.Drawing.Point(3, 336);
            this.getClientInfo.Name = "getClientInfo";
            this.getClientInfo.Size = new System.Drawing.Size(218, 55);
            this.getClientInfo.TabIndex = 6;
            this.getClientInfo.Tag = "getClientInfo";
            this.getClientInfo.Text = "Показать всю информацию по клиенту";
            this.getClientInfo.UseVisualStyleBackColor = true;
            this.getClientInfo.Click += new System.EventHandler(this.getClientInfo_Click);
            // 
            // registerNewPoliceCategory
            // 
            this.registerNewPoliceCategory.Location = new System.Drawing.Point(3, 3);
            this.registerNewPoliceCategory.Name = "registerNewPoliceCategory";
            this.registerNewPoliceCategory.Size = new System.Drawing.Size(218, 58);
            this.registerNewPoliceCategory.TabIndex = 1;
            this.registerNewPoliceCategory.Tag = "registerNewPoliceCategory";
            this.registerNewPoliceCategory.Text = "Зарегистрировать новую категорию полиса";
            this.registerNewPoliceCategory.UseVisualStyleBackColor = true;
            this.registerNewPoliceCategory.Click += new System.EventHandler(this.registerNewPoliceCategory_Click);
            // 
            // groupBoxIndividual
            // 
            this.groupBoxIndividual.Controls.Add(this.picturePathInput);
            this.groupBoxIndividual.Controls.Add(this.button3);
            this.groupBoxIndividual.Controls.Add(this.female);
            this.groupBoxIndividual.Controls.Add(this.male);
            this.groupBoxIndividual.Controls.Add(this.dateTimePicker1);
            this.groupBoxIndividual.Controls.Add(this.label10);
            this.groupBoxIndividual.Controls.Add(this.userDrivingExperience);
            this.groupBoxIndividual.Controls.Add(this.submitIndividual);
            this.groupBoxIndividual.Controls.Add(this.dateOfBirth);
            this.groupBoxIndividual.Controls.Add(this.userPhoneNumber);
            this.groupBoxIndividual.Controls.Add(this.surname);
            this.groupBoxIndividual.Controls.Add(this.userAddress);
            this.groupBoxIndividual.Controls.Add(this.label11);
            this.groupBoxIndividual.Controls.Add(this.clientName);
            this.groupBoxIndividual.Controls.Add(this.secondName);
            this.groupBoxIndividual.Controls.Add(this.label12);
            this.groupBoxIndividual.Controls.Add(this.clientSurname);
            this.groupBoxIndividual.Controls.Add(this.name);
            this.groupBoxIndividual.Controls.Add(this.label13);
            this.groupBoxIndividual.Controls.Add(this.label14);
            this.groupBoxIndividual.Controls.Add(this.clientSecondName);
            this.groupBoxIndividual.Location = new System.Drawing.Point(746, 67);
            this.groupBoxIndividual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxIndividual.Name = "groupBoxIndividual";
            this.groupBoxIndividual.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxIndividual.Size = new System.Drawing.Size(468, 483);
            this.groupBoxIndividual.TabIndex = 61;
            this.groupBoxIndividual.TabStop = false;
            this.groupBoxIndividual.Text = "Регистрация физ. лица";
            // 
            // picturePathInput
            // 
            this.picturePathInput.Location = new System.Drawing.Point(219, 225);
            this.picturePathInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picturePathInput.Name = "picturePathInput";
            this.picturePathInput.Size = new System.Drawing.Size(148, 26);
            this.picturePathInput.TabIndex = 110;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(266, 260);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.button3.MaximumSize = new System.Drawing.Size(300, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 31);
            this.button3.TabIndex = 109;
            this.button3.Text = "Выбрать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(332, 188);
            this.female.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(97, 24);
            this.female.TabIndex = 108;
            this.female.TabStop = true;
            this.female.Text = "женский";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(219, 188);
            this.male.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(97, 24);
            this.male.TabIndex = 107;
            this.male.TabStop = true;
            this.male.Text = "мужской";
            this.male.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(219, 151);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 26);
            this.dateTimePicker1.TabIndex = 106;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 302);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 20);
            this.label10.TabIndex = 105;
            this.label10.Text = "Опыт вождения (г.):";
            // 
            // userDrivingExperience
            // 
            this.userDrivingExperience.DecimalPlaces = 1;
            this.userDrivingExperience.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.userDrivingExperience.Location = new System.Drawing.Point(219, 298);
            this.userDrivingExperience.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userDrivingExperience.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.userDrivingExperience.Name = "userDrivingExperience";
            this.userDrivingExperience.Size = new System.Drawing.Size(150, 26);
            this.userDrivingExperience.TabIndex = 101;
            this.userDrivingExperience.Tag = "userDrivingExperience";
            // 
            // submitIndividual
            // 
            this.submitIndividual.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitIndividual.Location = new System.Drawing.Point(222, 426);
            this.submitIndividual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submitIndividual.Name = "submitIndividual";
            this.submitIndividual.Size = new System.Drawing.Size(148, 31);
            this.submitIndividual.TabIndex = 104;
            this.submitIndividual.Tag = "submitIndividual";
            this.submitIndividual.Text = "Зарегистрировать";
            this.submitIndividual.UseVisualStyleBackColor = true;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.AutoSize = true;
            this.dateOfBirth.Location = new System.Drawing.Point(66, 155);
            this.dateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(132, 20);
            this.dateOfBirth.TabIndex = 96;
            this.dateOfBirth.Tag = "";
            this.dateOfBirth.Text = "Дата рождения:";
            // 
            // userPhoneNumber
            // 
            this.userPhoneNumber.Location = new System.Drawing.Point(219, 378);
            this.userPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userPhoneNumber.Name = "userPhoneNumber";
            this.userPhoneNumber.Size = new System.Drawing.Size(148, 26);
            this.userPhoneNumber.TabIndex = 103;
            this.userPhoneNumber.Tag = "userPhoneNumber";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(111, 115);
            this.surname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(85, 20);
            this.surname.TabIndex = 95;
            this.surname.Text = "Фамилия:";
            // 
            // userAddress
            // 
            this.userAddress.Location = new System.Drawing.Point(219, 338);
            this.userAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userAddress.Name = "userAddress";
            this.userAddress.Size = new System.Drawing.Size(148, 26);
            this.userAddress.TabIndex = 102;
            this.userAddress.Tag = "userAddress";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(153, 191);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 97;
            this.label11.Text = "Пол:";
            // 
            // clientName
            // 
            this.clientName.Location = new System.Drawing.Point(219, 31);
            this.clientName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(148, 26);
            this.clientName.TabIndex = 90;
            this.clientName.Tag = "clientName";
            this.clientName.TextChanged += new System.EventHandler(this.clientName_TextChanged);
            // 
            // secondName
            // 
            this.secondName.AutoSize = true;
            this.secondName.Location = new System.Drawing.Point(114, 75);
            this.secondName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secondName.Name = "secondName";
            this.secondName.Size = new System.Drawing.Size(87, 20);
            this.secondName.TabIndex = 94;
            this.secondName.Text = "Отчество:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(138, 226);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 20);
            this.label12.TabIndex = 98;
            this.label12.Text = "Фото:";
            // 
            // clientSurname
            // 
            this.clientSurname.Location = new System.Drawing.Point(219, 111);
            this.clientSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clientSurname.Name = "clientSurname";
            this.clientSurname.Size = new System.Drawing.Size(148, 26);
            this.clientSurname.TabIndex = 91;
            this.clientSurname.Tag = "clientSurname";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(153, 35);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(44, 20);
            this.name.TabIndex = 93;
            this.name.Text = "Имя:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(51, 383);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 20);
            this.label13.TabIndex = 100;
            this.label13.Text = "Номер телефона:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(134, 343);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 20);
            this.label14.TabIndex = 99;
            this.label14.Text = "Адрес:";
            // 
            // clientSecondName
            // 
            this.clientSecondName.Location = new System.Drawing.Point(219, 71);
            this.clientSecondName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clientSecondName.Name = "clientSecondName";
            this.clientSecondName.Size = new System.Drawing.Size(148, 26);
            this.clientSecondName.TabIndex = 92;
            this.clientSecondName.Tag = "clientSecondName";
            // 
            // clientType
            // 
            this.clientType.FormattingEnabled = true;
            this.clientType.Items.AddRange(new object[] {
            "legal",
            "individual"});
            this.clientType.Location = new System.Drawing.Point(4, 8);
            this.clientType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clientType.Name = "clientType";
            this.clientType.Size = new System.Drawing.Size(180, 28);
            this.clientType.TabIndex = 0;
            this.clientType.SelectedIndexChanged += new System.EventHandler(this.clientType_SelectedIndexChanged);
            // 
            // groupBoxLegal
            // 
            this.groupBoxLegal.Controls.Add(this.textBox5);
            this.groupBoxLegal.Controls.Add(this.label9);
            this.groupBoxLegal.Controls.Add(this.textBox4);
            this.groupBoxLegal.Controls.Add(this.label8);
            this.groupBoxLegal.Controls.Add(this.label7);
            this.groupBoxLegal.Controls.Add(this.textBox3);
            this.groupBoxLegal.Controls.Add(this.label6);
            this.groupBoxLegal.Controls.Add(this.textBox1);
            this.groupBoxLegal.Controls.Add(this.submitLegalPerson);
            this.groupBoxLegal.Controls.Add(this.companyPhoneNumber);
            this.groupBoxLegal.Controls.Add(this.companyAddress);
            this.groupBoxLegal.Controls.Add(this.accountantName);
            this.groupBoxLegal.Controls.Add(this.label5);
            this.groupBoxLegal.Controls.Add(this.label4);
            this.groupBoxLegal.Controls.Add(this.label2);
            this.groupBoxLegal.Controls.Add(this.label3);
            this.groupBoxLegal.Controls.Add(this.taxUniqueNumber);
            this.groupBoxLegal.Controls.Add(this.label1);
            this.groupBoxLegal.Controls.Add(this.directorName);
            this.groupBoxLegal.Controls.Add(this.textBox2);
            this.groupBoxLegal.Controls.Add(this.companyName);
            this.groupBoxLegal.Location = new System.Drawing.Point(4, 49);
            this.groupBoxLegal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxLegal.Name = "groupBoxLegal";
            this.groupBoxLegal.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxLegal.Size = new System.Drawing.Size(468, 483);
            this.groupBoxLegal.TabIndex = 1;
            this.groupBoxLegal.TabStop = false;
            this.groupBoxLegal.Text = "Регистрация юр. лица";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(248, 309);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(148, 26);
            this.textBox5.TabIndex = 60;
            this.textBox5.Tag = "accountantName";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 314);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 20);
            this.label9.TabIndex = 59;
            this.label9.Text = "Accountant\'s name:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(248, 269);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(148, 26);
            this.textBox4.TabIndex = 58;
            this.textBox4.Tag = "accountantName";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 274);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 20);
            this.label8.TabIndex = 57;
            this.label8.Text = "Accountant\'s name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 189);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 56;
            this.label7.Text = "Director\'s name:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(248, 189);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 26);
            this.textBox3.TabIndex = 55;
            this.textBox3.Tag = "directorName";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "Director\'s name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 149);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 53;
            this.textBox1.Tag = "directorName";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // submitLegalPerson
            // 
            this.submitLegalPerson.Location = new System.Drawing.Point(285, 431);
            this.submitLegalPerson.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submitLegalPerson.Name = "submitLegalPerson";
            this.submitLegalPerson.Size = new System.Drawing.Size(112, 35);
            this.submitLegalPerson.TabIndex = 52;
            this.submitLegalPerson.Tag = "submitLegalPerson";
            this.submitLegalPerson.Text = "Submit";
            this.submitLegalPerson.UseVisualStyleBackColor = true;
            this.submitLegalPerson.Click += new System.EventHandler(this.submitLegalPerson_Click);
            // 
            // companyPhoneNumber
            // 
            this.companyPhoneNumber.Location = new System.Drawing.Point(248, 389);
            this.companyPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.companyPhoneNumber.Name = "companyPhoneNumber";
            this.companyPhoneNumber.Size = new System.Drawing.Size(148, 26);
            this.companyPhoneNumber.TabIndex = 51;
            this.companyPhoneNumber.Tag = "companyPhoneNumber";
            // 
            // companyAddress
            // 
            this.companyAddress.Location = new System.Drawing.Point(248, 349);
            this.companyAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.companyAddress.Name = "companyAddress";
            this.companyAddress.Size = new System.Drawing.Size(148, 26);
            this.companyAddress.TabIndex = 50;
            this.companyAddress.Tag = "companyAddress";
            // 
            // accountantName
            // 
            this.accountantName.Location = new System.Drawing.Point(248, 229);
            this.accountantName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accountantName.Name = "accountantName";
            this.accountantName.Size = new System.Drawing.Size(148, 26);
            this.accountantName.TabIndex = 49;
            this.accountantName.Tag = "accountantName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 394);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Company phone number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 354);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Company address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Accountant\'s name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Director\'s name:";
            // 
            // taxUniqueNumber
            // 
            this.taxUniqueNumber.AutoSize = true;
            this.taxUniqueNumber.Location = new System.Drawing.Point(87, 68);
            this.taxUniqueNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taxUniqueNumber.Name = "taxUniqueNumber";
            this.taxUniqueNumber.Size = new System.Drawing.Size(148, 20);
            this.taxUniqueNumber.TabIndex = 44;
            this.taxUniqueNumber.Tag = "taxUniqueNumber";
            this.taxUniqueNumber.Text = "Tax unique number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Company name:";
            // 
            // directorName
            // 
            this.directorName.Location = new System.Drawing.Point(248, 109);
            this.directorName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.directorName.Name = "directorName";
            this.directorName.Size = new System.Drawing.Size(148, 26);
            this.directorName.TabIndex = 42;
            this.directorName.Tag = "directorName";
            this.directorName.TextChanged += new System.EventHandler(this.directorName_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(248, 69);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 26);
            this.textBox2.TabIndex = 41;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // companyName
            // 
            this.companyName.Location = new System.Drawing.Point(248, 29);
            this.companyName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(148, 26);
            this.companyName.TabIndex = 40;
            this.companyName.Tag = "companyName";
            this.companyName.TextChanged += new System.EventHandler(this.companyName_TextChanged);
            // 
            // RegisterClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 643);
            this.Controls.Add(this.groupBoxIndividual);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegisterClient";
            this.Text = "Страховщик: регистрация клиента";
            this.Load += new System.EventHandler(this.RegisterClient_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxIndividual.ResumeLayout(false);
            this.groupBoxIndividual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDrivingExperience)).EndInit();
            this.groupBoxLegal.ResumeLayout(false);
            this.groupBoxLegal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button formPolice;
        private System.Windows.Forms.Button registerClientButton;
        private System.Windows.Forms.Button registerNewPoliceCategory;
        private System.Windows.Forms.Button showAllPoliceCategoriesAndCases;
        private System.Windows.Forms.Button showAllClientsInfo;
        private System.Windows.Forms.Button showAllClientPayments;
        private System.Windows.Forms.Button formPayment;
        private System.Windows.Forms.Button getClientInfo;
        private System.Windows.Forms.ComboBox clientType;
        private System.Windows.Forms.GroupBox groupBoxLegal;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button submitLegalPerson;
        private System.Windows.Forms.TextBox companyPhoneNumber;
        private System.Windows.Forms.TextBox companyAddress;
        private System.Windows.Forms.TextBox accountantName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label taxUniqueNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox directorName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox companyName;
        private System.Windows.Forms.GroupBox groupBoxIndividual;
        private System.Windows.Forms.TextBox picturePathInput;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown userDrivingExperience;
        private System.Windows.Forms.Button submitIndividual;
        private System.Windows.Forms.Label dateOfBirth;
        private System.Windows.Forms.TextBox userPhoneNumber;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.TextBox userAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox clientName;
        private System.Windows.Forms.Label secondName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox clientSurname;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox clientSecondName;
        private System.Windows.Forms.Button registerNewInsuranceCase;
    }
}