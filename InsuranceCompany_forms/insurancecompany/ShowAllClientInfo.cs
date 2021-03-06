﻿using InsuranceCompany.insuranceCompany.DAO.impl;
using InsuranceCompany.insuranceCompany.command;
using InsuranceCompany.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Documents;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;


namespace InsuranceCompany
{
    public partial class ShowAllClientInfo : Form
    {
        public ShowAllClientInfo()
        {
            InitializeComponent();


            // CreateTable();

            //Excel.Application excelapp;
            //excelapp = new Excel.Application();
            //excelapp.Visible = true;
            //excelapp.Workbooks.OpenText(
            // @"C:\Users\Maria\Desktop\Insurance-company\InsuranceCompany_forms\a.txt",
            // Excel.XlPlatform.xlWindows,
            // 1,            //С первой строки
            // Excel.XlTextParsingType.xlDelimited, //Текст с разделителями
            // Excel.XlTextQualifier.xlTextQualifierDoubleQuote, //Признак окончания разбора строки
            // true,          //Разделители одинарные
            // true,          //Разделители :Tab
            // false,         //Semicolon
            // false,         //Comma
            // false,         //Space
            // false,         //Other
            // Type.Missing,  //OtherChar
            // new object[] {new object[]{1,Excel.XlColumnDataType.xlSkipColumn},
            //    new object[]{2,Excel.XlColumnDataType.xlGeneralFormat},
            //    new object[]{2,Excel.XlColumnDataType.xlMDYFormat},
            //    new object[]{3,Excel.XlColumnDataType.xlMYDFormat},
            //    new object[]{4,Excel.XlColumnDataType.xlTextFormat},
            //    new object[]{5,Excel.XlColumnDataType.xlTextFormat}},
            // Type.Missing,  //Размещение текста
            // ".",           //Разделитель десятичных разрядов
            //",");           //Разделитель тысяч
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowAllClients_Load(object sender, EventArgs e)
        {

        }

        private void registerNewInsuranceCase_Click(object sender, EventArgs e)
        {
            FormNewInsuranceCase cw = new FormNewInsuranceCase();
            cw.Show();
            this.Close();
        }

        private void registerNewPoliceCategory_Click(object sender, EventArgs e)
        {
            FormNewPoliceCategory cw = new FormNewPoliceCategory();
            cw.Show();
            this.Close();
        }

        private void showAllClientsInfo_Click(object sender, EventArgs e)
        {
            ShowAllClientInfoAndPolicies cw = new ShowAllClientInfoAndPolicies();
            cw.Show();
            this.Close();
        }

        private void showAllClientPayments_Click(object sender, EventArgs e)
        {
            ShowAllClientsPayments cw = new ShowAllClientsPayments();
            cw.Show();
            this.Close();
        }

        private void showAllPoliceCategoriesAndCases_Click(object sender, EventArgs e)
        {
            ShowAllPoliceCategories cw = new ShowAllPoliceCategories();
            cw.Show();
            this.Close();
        }

        private void formPayment_Click(object sender, EventArgs e)
        {
            FormPaymentAdmin cw = new FormPaymentAdmin();
            cw.Show();
            this.Close();
        }

        private void getClientInfo_Click(object sender, EventArgs e)
        {
            ShowAllClientInfo cw = new ShowAllClientInfo();
            cw.Show();
            this.Close();
        }

        private void registerClientButton_Click(object sender, EventArgs e)
        {
            RegisterClient cw = new RegisterClient();
            cw.Show();
            this.Close();
        }

        private void registerPolice_Click(object sender, EventArgs e)
        {
            RegisterPolice cw = new RegisterPolice();
            cw.Show();
            this.Close();
        }

        private void clientType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clientType.SelectedItem.Equals("юр. лицо"))
            {
                name.Text = "Выберите компанию";
                name.Items.Clear();
                GetAllLegalClientsInfo command = new GetAllLegalClientsInfo();
                List<LegalPerson> legalPersonList = command.getAllLegalPersonInfo();
                name.Items.AddRange(legalPersonList.ToArray());
            }
            if (clientType.SelectedItem.Equals("физ. лицо"))
            {
                name.Text = "Выберите ФИО";
                name.Items.Clear();
                GetAllIndividualClients command = new GetAllIndividualClients();
                List<Individual> individualList = command.getAllIndividualInfo();
                name.Items.AddRange(individualList.ToArray());
            }
        }

        private void name_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(clientType.SelectedItem.Equals("юр. лицо"))
           {
               ShowRichText cw = new ShowRichText();
               cw.Client = (LegalPerson)name.SelectedItem;
               cw.Show();
           }
           if (clientType.SelectedItem.Equals("физ. лицо"))
           {
               ShowRichText cw = new ShowRichText();
               cw.Individual = (Individual)name.SelectedItem;
               cw.Show();
           }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
