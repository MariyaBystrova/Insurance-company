using InsuranceCompany.entity;
using InsuranceCompany.insuranceCompany.command;
using InsuranceCompany.insuranceCompany.DAO.impl;
using System;
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
    public partial class FormNewPoliceCategory : Form
    {
        public FormNewPoliceCategory()
        {
            InitializeComponent();
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
            ShowAllClientInfo cw = new ShowAllClientInfo();
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

        private void policeCategoryNameInput_TextChanged(object sender, EventArgs e)
        {
            policeCategoryNameInput.Validating += policeCategoryNameInput_Validating;
        }

        private void policeCategoryNameInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(policeCategoryNameInput.Text))
            {
                errorProvider1.SetError(policeCategoryNameInput, "Не указано название!");
            }
            else if (policeCategoryNameInput.Text.Length < 4)
            {
                errorProvider1.SetError(policeCategoryNameInput, "Слишком короткое название!");
            }
            else
            {
                errorProvider1.Clear();
            }
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

        private void submit_Click(object sender, EventArgs e)
        {
            String categoryName = policeCategoryNameInput.Text;
            RegisterNewInsuranceCategoryCommand command = new RegisterNewInsuranceCategoryCommand();
            command.registerNewInsuranceCategory(categoryName);
        }
    }
}
