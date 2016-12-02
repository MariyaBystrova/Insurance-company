﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceCompany
{
    public partial class FormNewInsuranceCase : Form
    {
        public FormNewInsuranceCase()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FormNewInsuranceCase_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
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
            ShowAllClients cw = new ShowAllClients();
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
            ShowAllClients cw = new ShowAllClients();
            cw.Show();
            this.Close();
        }

        private void insuranceCaseNameInput_TextChanged(object sender, EventArgs e)
        {
            insuranceCaseNameInput.Validating += insuranceCaseNameInput_Validating;
        }


        private void insuranceCaseNameInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(insuranceCaseNameInput.Text))
            {
                errorProvider1.SetError(insuranceCaseNameInput, "Не указано название!");
            }
            else if (insuranceCaseNameInput.Text.Length < 4)
            {
                errorProvider1.SetError(insuranceCaseNameInput, "Слишком короткое название!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
           
        }
    }
}