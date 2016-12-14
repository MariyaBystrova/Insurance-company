namespace InsuranceCompany
{
    partial class RegisterPolice
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
            this.registerPoliceMenu = new System.Windows.Forms.Button();
            this.formPolice = new System.Windows.Forms.Button();
            this.registerClient = new System.Windows.Forms.Button();
            this.registerClientButton = new System.Windows.Forms.Button();
            this.registerNewPoliceCategory = new System.Windows.Forms.Button();
            this.showAllPoliceCategoriesAndCases = new System.Windows.Forms.Button();
            this.showAllClientsInfo = new System.Windows.Forms.Button();
            this.showAllClientPayments = new System.Windows.Forms.Button();
            this.formPayment = new System.Windows.Forms.Button();
            this.getClientInfo = new System.Windows.Forms.Button();
            this.groupBoxIndividual = new System.Windows.Forms.GroupBox();
            this.buttonIndividual = new System.Windows.Forms.Button();
            this.endDateIndividualDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateIndividualDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.policeAmountIndividualNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.policeCoastIndividualNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fslNameIndividualComboBox = new System.Windows.Forms.ComboBox();
            this.policeCategoryIndividualComboBox = new System.Windows.Forms.ComboBox();
            this.insurerIdIndividualComboBox = new System.Windows.Forms.ComboBox();
            this.endDateIndividual = new System.Windows.Forms.Label();
            this.startDateIndividual = new System.Windows.Forms.Label();
            this.policeAmountIndividual = new System.Windows.Forms.Label();
            this.policeCoastIndividual = new System.Windows.Forms.Label();
            this.fslNameIndividual = new System.Windows.Forms.Label();
            this.policeCategoryIndividual = new System.Windows.Forms.Label();
            this.insurerIndividual = new System.Windows.Forms.Label();
            this.groupBoxLegal = new System.Windows.Forms.GroupBox();
            this.submitLegal = new System.Windows.Forms.Button();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.policeAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.policeCoastNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.policeCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.insurerComboBox = new System.Windows.Forms.ComboBox();
            this.endDate = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.Label();
            this.policeAmount = new System.Windows.Forms.Label();
            this.policeCoast = new System.Windows.Forms.Label();
            this.nameClient = new System.Windows.Forms.Label();
            this.policeCategory = new System.Windows.Forms.Label();
            this.insurer = new System.Windows.Forms.Label();
            this.clientType = new System.Windows.Forms.ComboBox();
            this.registerLegalPersonLink = new System.Windows.Forms.LinkLabel();
            this.registerIndividuaLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxIndividual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.policeAmountIndividualNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeCoastIndividualNumericUpDown)).BeginInit();
            this.groupBoxLegal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.policeAmountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeCoastNumericUpDown)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxLegal);
            this.splitContainer1.Panel2.Controls.Add(this.clientType);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(480, 430);
            this.splitContainer1.SplitterDistance = 157;
            this.splitContainer1.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.registerPoliceMenu, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.formPolice, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.registerClient, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.registerClientButton, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.registerNewPoliceCategory, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.showAllPoliceCategoriesAndCases, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.showAllClientsInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.showAllClientPayments, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.formPayment, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.getClientInfo, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(152, 424);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // registerPoliceMenu
            // 
            this.registerPoliceMenu.Location = new System.Drawing.Point(3, 384);
            this.registerPoliceMenu.Name = "registerPoliceMenu";
            this.registerPoliceMenu.Size = new System.Drawing.Size(144, 36);
            this.registerPoliceMenu.TabIndex = 14;
            this.registerPoliceMenu.Text = "Оформление полиса";
            this.registerPoliceMenu.UseVisualStyleBackColor = true;
            this.registerPoliceMenu.Click += new System.EventHandler(this.registerPoliceMenu_Click);
            // 
            // formPolice
            // 
            this.formPolice.Location = new System.Drawing.Point(3, 302);
            this.formPolice.Name = "formPolice";
            this.formPolice.Size = new System.Drawing.Size(144, 35);
            this.formPolice.TabIndex = 2;
            this.formPolice.Text = "Оформление полиса";
            this.formPolice.UseVisualStyleBackColor = true;
            this.formPolice.Click += new System.EventHandler(this.formPolice_Click);
            // 
            // registerClient
            // 
            this.registerClient.Location = new System.Drawing.Point(3, 343);
            this.registerClient.Name = "registerClient";
            this.registerClient.Size = new System.Drawing.Size(144, 35);
            this.registerClient.TabIndex = 13;
            this.registerClient.Text = "Зарегистрировать клиента";
            this.registerClient.UseVisualStyleBackColor = true;
            this.registerClient.Click += new System.EventHandler(this.registerClient_Click);
            // 
            // registerClientButton
            // 
            this.registerClientButton.Location = new System.Drawing.Point(3, 261);
            this.registerClientButton.Name = "registerClientButton";
            this.registerClientButton.Size = new System.Drawing.Size(144, 35);
            this.registerClientButton.TabIndex = 1;
            this.registerClientButton.Text = "Зарегистрировать клиента";
            this.registerClientButton.UseVisualStyleBackColor = true;
            this.registerClientButton.Click += new System.EventHandler(this.registerClientButton_Click);
            // 
            // registerNewPoliceCategory
            // 
            this.registerNewPoliceCategory.Location = new System.Drawing.Point(2, 2);
            this.registerNewPoliceCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.showAllPoliceCategoriesAndCases.Location = new System.Drawing.Point(2, 126);
            this.showAllPoliceCategoriesAndCases.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showAllPoliceCategoriesAndCases.Name = "showAllPoliceCategoriesAndCases";
            this.showAllPoliceCategoriesAndCases.Size = new System.Drawing.Size(145, 49);
            this.showAllPoliceCategoriesAndCases.TabIndex = 4;
            this.showAllPoliceCategoriesAndCases.Tag = "showAllPoliceCategoriesAndCases";
            this.showAllPoliceCategoriesAndCases.Text = "Показать все категории полисаов и их страховые случаи";
            this.showAllPoliceCategoriesAndCases.UseVisualStyleBackColor = true;
            this.showAllPoliceCategoriesAndCases.Click += new System.EventHandler(this.showAllPoliceCategoriesAndCases_Click);
            // 
            // showAllClientsInfo
            // 
            this.showAllClientsInfo.Location = new System.Drawing.Point(2, 44);
            this.showAllClientsInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showAllClientsInfo.Name = "showAllClientsInfo";
            this.showAllClientsInfo.Size = new System.Drawing.Size(145, 36);
            this.showAllClientsInfo.TabIndex = 2;
            this.showAllClientsInfo.Tag = "showAllClientsInfo";
            this.showAllClientsInfo.Text = "Показать всю информацию о клиентах и полисах";
            this.showAllClientsInfo.UseVisualStyleBackColor = true;
            this.showAllClientsInfo.Click += new System.EventHandler(this.showAllClientsInfo_Click);
            // 
            // showAllClientPayments
            // 
            this.showAllClientPayments.Location = new System.Drawing.Point(2, 84);
            this.showAllClientPayments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.formPayment.Location = new System.Drawing.Point(2, 179);
            this.formPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.getClientInfo.Location = new System.Drawing.Point(2, 220);
            this.getClientInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.getClientInfo.Name = "getClientInfo";
            this.getClientInfo.Size = new System.Drawing.Size(145, 36);
            this.getClientInfo.TabIndex = 6;
            this.getClientInfo.Tag = "getClientInfo";
            this.getClientInfo.Text = "Показать всю информацию по клиенту";
            this.getClientInfo.UseVisualStyleBackColor = true;
            this.getClientInfo.Click += new System.EventHandler(this.getClientInfo_Click);
            // 
            // groupBoxIndividual
            // 
            this.groupBoxIndividual.Controls.Add(this.fslNameIndividualComboBox);
            this.groupBoxIndividual.Controls.Add(this.registerIndividuaLink);
            this.groupBoxIndividual.Controls.Add(this.buttonIndividual);
            this.groupBoxIndividual.Controls.Add(this.endDateIndividualDateTimePicker);
            this.groupBoxIndividual.Controls.Add(this.startDateIndividualDateTimePicker);
            this.groupBoxIndividual.Controls.Add(this.policeAmountIndividualNumericUpDown);
            this.groupBoxIndividual.Controls.Add(this.policeCoastIndividualNumericUpDown);
            this.groupBoxIndividual.Controls.Add(this.policeCategoryIndividualComboBox);
            this.groupBoxIndividual.Controls.Add(this.insurerIdIndividualComboBox);
            this.groupBoxIndividual.Controls.Add(this.endDateIndividual);
            this.groupBoxIndividual.Controls.Add(this.startDateIndividual);
            this.groupBoxIndividual.Controls.Add(this.policeAmountIndividual);
            this.groupBoxIndividual.Controls.Add(this.policeCoastIndividual);
            this.groupBoxIndividual.Controls.Add(this.fslNameIndividual);
            this.groupBoxIndividual.Controls.Add(this.policeCategoryIndividual);
            this.groupBoxIndividual.Controls.Add(this.insurerIndividual);
            this.groupBoxIndividual.Location = new System.Drawing.Point(518, 85);
            this.groupBoxIndividual.Name = "groupBoxIndividual";
            this.groupBoxIndividual.Size = new System.Drawing.Size(300, 308);
            this.groupBoxIndividual.TabIndex = 12;
            this.groupBoxIndividual.TabStop = false;
            this.groupBoxIndividual.Text = "Регистрация полиса физ. лица";
            // 
            // buttonIndividual
            // 
            this.buttonIndividual.Location = new System.Drawing.Point(177, 250);
            this.buttonIndividual.Name = "buttonIndividual";
            this.buttonIndividual.Size = new System.Drawing.Size(111, 23);
            this.buttonIndividual.TabIndex = 59;
            this.buttonIndividual.Text = "Зарегистрировать";
            this.buttonIndividual.UseVisualStyleBackColor = true;
            this.buttonIndividual.Click += new System.EventHandler(this.buttonIndividual_Click);
            // 
            // endDateIndividualDateTimePicker
            // 
            this.endDateIndividualDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateIndividualDateTimePicker.Location = new System.Drawing.Point(168, 212);
            this.endDateIndividualDateTimePicker.Name = "endDateIndividualDateTimePicker";
            this.endDateIndividualDateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.endDateIndividualDateTimePicker.TabIndex = 58;
            this.endDateIndividualDateTimePicker.ValueChanged += new System.EventHandler(this.endDateIndividualDateTimePicker_ValueChanged);
            // 
            // startDateIndividualDateTimePicker
            // 
            this.startDateIndividualDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateIndividualDateTimePicker.Location = new System.Drawing.Point(168, 183);
            this.startDateIndividualDateTimePicker.Name = "startDateIndividualDateTimePicker";
            this.startDateIndividualDateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.startDateIndividualDateTimePicker.TabIndex = 57;
            this.startDateIndividualDateTimePicker.ValueChanged += new System.EventHandler(this.startDateIndividualDateTimePicker_ValueChanged);
            // 
            // policeAmountIndividualNumericUpDown
            // 
            this.policeAmountIndividualNumericUpDown.Location = new System.Drawing.Point(168, 153);
            this.policeAmountIndividualNumericUpDown.Name = "policeAmountIndividualNumericUpDown";
            this.policeAmountIndividualNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.policeAmountIndividualNumericUpDown.TabIndex = 56;
            this.policeAmountIndividualNumericUpDown.ValueChanged += new System.EventHandler(this.policeAmountIndividualNumericUpDown_ValueChanged);
            // 
            // policeCoastIndividualNumericUpDown
            // 
            this.policeCoastIndividualNumericUpDown.Location = new System.Drawing.Point(168, 123);
            this.policeCoastIndividualNumericUpDown.Name = "policeCoastIndividualNumericUpDown";
            this.policeCoastIndividualNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.policeCoastIndividualNumericUpDown.TabIndex = 55;
            this.policeCoastIndividualNumericUpDown.ValueChanged += new System.EventHandler(this.policeCoastIndividualNumericUpDown_ValueChanged);
            // 
            // fslNameIndividualComboBox
            // 
            this.fslNameIndividualComboBox.FormattingEnabled = true;
            this.fslNameIndividualComboBox.Location = new System.Drawing.Point(167, 29);
            this.fslNameIndividualComboBox.Name = "fslNameIndividualComboBox";
            this.fslNameIndividualComboBox.Size = new System.Drawing.Size(121, 21);
            this.fslNameIndividualComboBox.TabIndex = 54;
            this.fslNameIndividualComboBox.SelectedIndexChanged += new System.EventHandler(this.fslNameIndividualComboBox_SelectedIndexChanged);
            // 
            // policeCategoryIndividualComboBox
            // 
            this.policeCategoryIndividualComboBox.FormattingEnabled = true;
            this.policeCategoryIndividualComboBox.Location = new System.Drawing.Point(168, 96);
            this.policeCategoryIndividualComboBox.Name = "policeCategoryIndividualComboBox";
            this.policeCategoryIndividualComboBox.Size = new System.Drawing.Size(121, 21);
            this.policeCategoryIndividualComboBox.TabIndex = 53;
            this.policeCategoryIndividualComboBox.SelectedIndexChanged += new System.EventHandler(this.policeCategoryIndividualComboBox_SelectedIndexChanged);
            // 
            // insurerIdIndividualComboBox
            // 
            this.insurerIdIndividualComboBox.FormattingEnabled = true;
            this.insurerIdIndividualComboBox.Location = new System.Drawing.Point(168, 69);
            this.insurerIdIndividualComboBox.Name = "insurerIdIndividualComboBox";
            this.insurerIdIndividualComboBox.Size = new System.Drawing.Size(121, 21);
            this.insurerIdIndividualComboBox.TabIndex = 52;
            this.insurerIdIndividualComboBox.SelectedIndexChanged += new System.EventHandler(this.insurerIdIndividualComboBox_SelectedIndexChanged);
            // 
            // endDateIndividual
            // 
            this.endDateIndividual.AutoSize = true;
            this.endDateIndividual.Location = new System.Drawing.Point(58, 217);
            this.endDateIndividual.Name = "endDateIndividual";
            this.endDateIndividual.Size = new System.Drawing.Size(92, 13);
            this.endDateIndividual.TabIndex = 51;
            this.endDateIndividual.Text = "Дата окончания:";
            // 
            // startDateIndividual
            // 
            this.startDateIndividual.AutoSize = true;
            this.startDateIndividual.Location = new System.Drawing.Point(50, 183);
            this.startDateIndividual.Name = "startDateIndividual";
            this.startDateIndividual.Size = new System.Drawing.Size(100, 13);
            this.startDateIndividual.TabIndex = 50;
            this.startDateIndividual.Text = "Дата заключения:";
            // 
            // policeAmountIndividual
            // 
            this.policeAmountIndividual.AutoSize = true;
            this.policeAmountIndividual.Location = new System.Drawing.Point(67, 155);
            this.policeAmountIndividual.Name = "policeAmountIndividual";
            this.policeAmountIndividual.Size = new System.Drawing.Size(83, 13);
            this.policeAmountIndividual.TabIndex = 49;
            this.policeAmountIndividual.Text = "Сумма полиса:";
            // 
            // policeCoastIndividual
            // 
            this.policeCoastIndividual.AutoSize = true;
            this.policeCoastIndividual.Location = new System.Drawing.Point(18, 125);
            this.policeCoastIndividual.Name = "policeCoastIndividual";
            this.policeCoastIndividual.Size = new System.Drawing.Size(132, 13);
            this.policeCoastIndividual.TabIndex = 48;
            this.policeCoastIndividual.Text = "Стоимость страхования:";
            // 
            // fslNameIndividual
            // 
            this.fslNameIndividual.AutoSize = true;
            this.fslNameIndividual.Location = new System.Drawing.Point(113, 32);
            this.fslNameIndividual.Name = "fslNameIndividual";
            this.fslNameIndividual.Size = new System.Drawing.Size(37, 13);
            this.fslNameIndividual.TabIndex = 47;
            this.fslNameIndividual.Text = "ФИО:";
            // 
            // policeCategoryIndividual
            // 
            this.policeCategoryIndividual.AutoSize = true;
            this.policeCategoryIndividual.Location = new System.Drawing.Point(49, 99);
            this.policeCategoryIndividual.Name = "policeCategoryIndividual";
            this.policeCategoryIndividual.Size = new System.Drawing.Size(102, 13);
            this.policeCategoryIndividual.TabIndex = 46;
            this.policeCategoryIndividual.Text = "Категория полиса:";
            // 
            // insurerIndividual
            // 
            this.insurerIndividual.AutoSize = true;
            this.insurerIndividual.Location = new System.Drawing.Point(79, 72);
            this.insurerIndividual.Name = "insurerIndividual";
            this.insurerIndividual.Size = new System.Drawing.Size(72, 13);
            this.insurerIndividual.TabIndex = 45;
            this.insurerIndividual.Text = "Страховщик:";
            // 
            // groupBoxLegal
            // 
            this.groupBoxLegal.Controls.Add(this.companyComboBox);
            this.groupBoxLegal.Controls.Add(this.registerLegalPersonLink);
            this.groupBoxLegal.Controls.Add(this.submitLegal);
            this.groupBoxLegal.Controls.Add(this.endDateDateTimePicker);
            this.groupBoxLegal.Controls.Add(this.startDateDateTimePicker);
            this.groupBoxLegal.Controls.Add(this.policeAmountNumericUpDown);
            this.groupBoxLegal.Controls.Add(this.policeCoastNumericUpDown);
            this.groupBoxLegal.Controls.Add(this.policeCategoryComboBox);
            this.groupBoxLegal.Controls.Add(this.insurerComboBox);
            this.groupBoxLegal.Controls.Add(this.endDate);
            this.groupBoxLegal.Controls.Add(this.startDate);
            this.groupBoxLegal.Controls.Add(this.policeAmount);
            this.groupBoxLegal.Controls.Add(this.policeCoast);
            this.groupBoxLegal.Controls.Add(this.nameClient);
            this.groupBoxLegal.Controls.Add(this.policeCategory);
            this.groupBoxLegal.Controls.Add(this.insurer);
            this.groupBoxLegal.Location = new System.Drawing.Point(3, 73);
            this.groupBoxLegal.Name = "groupBoxLegal";
            this.groupBoxLegal.Size = new System.Drawing.Size(306, 315);
            this.groupBoxLegal.TabIndex = 2;
            this.groupBoxLegal.TabStop = false;
            this.groupBoxLegal.Text = "Оформление полиса юр. лицу";
            // 
            // submitLegal
            // 
            this.submitLegal.Location = new System.Drawing.Point(166, 256);
            this.submitLegal.Name = "submitLegal";
            this.submitLegal.Size = new System.Drawing.Size(111, 23);
            this.submitLegal.TabIndex = 14;
            this.submitLegal.Text = "Зарегистрировать";
            this.submitLegal.UseVisualStyleBackColor = true;
            this.submitLegal.Click += new System.EventHandler(this.submitLegal_Click);
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateDateTimePicker.Location = new System.Drawing.Point(157, 218);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.endDateDateTimePicker.TabIndex = 13;
            this.endDateDateTimePicker.ValueChanged += new System.EventHandler(this.endDateDateTimePicker_ValueChanged);
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateDateTimePicker.Location = new System.Drawing.Point(157, 189);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.startDateDateTimePicker.TabIndex = 12;
            this.startDateDateTimePicker.ValueChanged += new System.EventHandler(this.startDateDateTimePicker_ValueChanged);
            // 
            // policeAmountNumericUpDown
            // 
            this.policeAmountNumericUpDown.Location = new System.Drawing.Point(157, 159);
            this.policeAmountNumericUpDown.Name = "policeAmountNumericUpDown";
            this.policeAmountNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.policeAmountNumericUpDown.TabIndex = 11;
            this.policeAmountNumericUpDown.ValueChanged += new System.EventHandler(this.policeAmountNumericUpDown_ValueChanged);
            // 
            // policeCoastNumericUpDown
            // 
            this.policeCoastNumericUpDown.Location = new System.Drawing.Point(157, 129);
            this.policeCoastNumericUpDown.Name = "policeCoastNumericUpDown";
            this.policeCoastNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.policeCoastNumericUpDown.TabIndex = 10;
            this.policeCoastNumericUpDown.ValueChanged += new System.EventHandler(this.policeCoastNumericUpDown_ValueChanged);
            // 
            // companyComboBox
            // 
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(156, 40);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(121, 21);
            this.companyComboBox.TabIndex = 9;
            this.companyComboBox.SelectedIndexChanged += new System.EventHandler(this.companyComboBox_SelectedIndexChanged);
            // 
            // policeCategoryComboBox
            // 
            this.policeCategoryComboBox.FormattingEnabled = true;
            this.policeCategoryComboBox.Location = new System.Drawing.Point(156, 102);
            this.policeCategoryComboBox.Name = "policeCategoryComboBox";
            this.policeCategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.policeCategoryComboBox.TabIndex = 8;
            this.policeCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.policeCategoryComboBox_SelectedIndexChanged);
            // 
            // insurerComboBox
            // 
            this.insurerComboBox.FormattingEnabled = true;
            this.insurerComboBox.Location = new System.Drawing.Point(156, 75);
            this.insurerComboBox.Name = "insurerComboBox";
            this.insurerComboBox.Size = new System.Drawing.Size(121, 21);
            this.insurerComboBox.TabIndex = 7;
            this.insurerComboBox.SelectedIndexChanged += new System.EventHandler(this.insurerComboBox_SelectedIndexChanged);
            // 
            // endDate
            // 
            this.endDate.AutoSize = true;
            this.endDate.Location = new System.Drawing.Point(47, 223);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(92, 13);
            this.endDate.TabIndex = 6;
            this.endDate.Text = "Дата окончания:";
            // 
            // startDate
            // 
            this.startDate.AutoSize = true;
            this.startDate.Location = new System.Drawing.Point(39, 189);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(100, 13);
            this.startDate.TabIndex = 5;
            this.startDate.Text = "Дата заключения:";
            // 
            // policeAmount
            // 
            this.policeAmount.AutoSize = true;
            this.policeAmount.Location = new System.Drawing.Point(56, 161);
            this.policeAmount.Name = "policeAmount";
            this.policeAmount.Size = new System.Drawing.Size(83, 13);
            this.policeAmount.TabIndex = 4;
            this.policeAmount.Text = "Сумма полиса:";
            // 
            // policeCoast
            // 
            this.policeCoast.AutoSize = true;
            this.policeCoast.Location = new System.Drawing.Point(7, 131);
            this.policeCoast.Name = "policeCoast";
            this.policeCoast.Size = new System.Drawing.Size(132, 13);
            this.policeCoast.TabIndex = 3;
            this.policeCoast.Text = "Стоимость страхования:";
            // 
            // nameClient
            // 
            this.nameClient.AutoSize = true;
            this.nameClient.Location = new System.Drawing.Point(78, 43);
            this.nameClient.Name = "nameClient";
            this.nameClient.Size = new System.Drawing.Size(61, 13);
            this.nameClient.TabIndex = 2;
            this.nameClient.Text = "Компания:";
            // 
            // policeCategory
            // 
            this.policeCategory.AutoSize = true;
            this.policeCategory.Location = new System.Drawing.Point(37, 105);
            this.policeCategory.Name = "policeCategory";
            this.policeCategory.Size = new System.Drawing.Size(102, 13);
            this.policeCategory.TabIndex = 1;
            this.policeCategory.Text = "Категория полиса:";
            // 
            // insurer
            // 
            this.insurer.AutoSize = true;
            this.insurer.Location = new System.Drawing.Point(67, 78);
            this.insurer.Name = "insurer";
            this.insurer.Size = new System.Drawing.Size(72, 13);
            this.insurer.TabIndex = 0;
            this.insurer.Text = "Страховщик:";
            // 
            // clientType
            // 
            this.clientType.FormattingEnabled = true;
            this.clientType.Items.AddRange(new object[] {
            "юр. лицо",
            "физ. лицо"});
            this.clientType.Location = new System.Drawing.Point(18, 22);
            this.clientType.Name = "clientType";
            this.clientType.Size = new System.Drawing.Size(121, 21);
            this.clientType.TabIndex = 1;
            this.clientType.SelectedIndexChanged += new System.EventHandler(this.clientType_SelectedIndexChanged);
            // 
            // registerLegalPersonLink
            // 
            this.registerLegalPersonLink.AutoSize = true;
            this.registerLegalPersonLink.Location = new System.Drawing.Point(158, 59);
            this.registerLegalPersonLink.Name = "registerLegalPersonLink";
            this.registerLegalPersonLink.Size = new System.Drawing.Size(119, 13);
            this.registerLegalPersonLink.TabIndex = 15;
            this.registerLegalPersonLink.TabStop = true;
            this.registerLegalPersonLink.Text = "Регистрация юр. лица";
            this.registerLegalPersonLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLegalPersonLink_LinkClicked);
            // 
            // registerIndividuaLink
            // 
            this.registerIndividuaLink.AutoSize = true;
            this.registerIndividuaLink.Location = new System.Drawing.Point(165, 48);
            this.registerIndividuaLink.Name = "registerIndividuaLink";
            this.registerIndividuaLink.Size = new System.Drawing.Size(125, 13);
            this.registerIndividuaLink.TabIndex = 60;
            this.registerIndividuaLink.TabStop = true;
            this.registerIndividuaLink.Text = "Регистрация физ. лица";
            this.registerIndividuaLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerIndividuaLink_LinkClicked);
            // 
            // RegisterPolice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 476);
            this.Controls.Add(this.groupBoxIndividual);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegisterPolice";
            this.Text = "Страховщик: оформление полиса";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxIndividual.ResumeLayout(false);
            this.groupBoxIndividual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.policeAmountIndividualNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeCoastIndividualNumericUpDown)).EndInit();
            this.groupBoxLegal.ResumeLayout(false);
            this.groupBoxLegal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.policeAmountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeCoastNumericUpDown)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBoxLegal;
        private System.Windows.Forms.ComboBox clientType;
        private System.Windows.Forms.Label endDate;
        private System.Windows.Forms.Label startDate;
        private System.Windows.Forms.Label policeAmount;
        private System.Windows.Forms.Label policeCoast;
        private System.Windows.Forms.Label nameClient;
        private System.Windows.Forms.Label policeCategory;
        private System.Windows.Forms.Label insurer;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.NumericUpDown policeAmountNumericUpDown;
        private System.Windows.Forms.NumericUpDown policeCoastNumericUpDown;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.ComboBox policeCategoryComboBox;
        private System.Windows.Forms.ComboBox insurerComboBox;
        private System.Windows.Forms.Button submitLegal;
        private System.Windows.Forms.GroupBox groupBoxIndividual;
        private System.Windows.Forms.Button buttonIndividual;
        private System.Windows.Forms.DateTimePicker endDateIndividualDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateIndividualDateTimePicker;
        private System.Windows.Forms.NumericUpDown policeAmountIndividualNumericUpDown;
        private System.Windows.Forms.NumericUpDown policeCoastIndividualNumericUpDown;
        private System.Windows.Forms.ComboBox fslNameIndividualComboBox;
        private System.Windows.Forms.ComboBox policeCategoryIndividualComboBox;
        private System.Windows.Forms.ComboBox insurerIdIndividualComboBox;
        private System.Windows.Forms.Label endDateIndividual;
        private System.Windows.Forms.Label startDateIndividual;
        private System.Windows.Forms.Label policeAmountIndividual;
        private System.Windows.Forms.Label policeCoastIndividual;
        private System.Windows.Forms.Label fslNameIndividual;
        private System.Windows.Forms.Label policeCategoryIndividual;
        private System.Windows.Forms.Label insurerIndividual;
        private System.Windows.Forms.Button registerPoliceMenu;
        private System.Windows.Forms.Button registerClient;
        private System.Windows.Forms.LinkLabel registerLegalPersonLink;
        private System.Windows.Forms.LinkLabel registerIndividuaLink;
    }
}