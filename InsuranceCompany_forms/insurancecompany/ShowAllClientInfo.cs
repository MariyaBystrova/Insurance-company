using InsuranceCompany.insuranceCompany.DAO.impl;
using InsuranceCompany.insuranceCompany.command;
using InsuranceCompany.entity;
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
    public partial class ShowAllClientInfo : Form
    {
        public ShowAllClientInfo()
        {
            InitializeComponent();
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
                List<Individual> individualList = command.getAllLegalPersonInfo();
                name.Items.AddRange(individualList.ToArray());
            }
        }

        private void name_SelectedIndexChanged(object sender, EventArgs e)
        {
            
               
        }

    }
}
