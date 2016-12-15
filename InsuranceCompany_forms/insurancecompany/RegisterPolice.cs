using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InsuranceCompany.insuranceCompany.DAO.impl;
using InsuranceCompany.insuranceCompany.command;
using InsuranceCompany.entity;

namespace InsuranceCompany
{
    public partial class RegisterPolice : Form
    {
        public RegisterPolice()
        {
            InitializeComponent();
          
            groupBoxIndividual.Visible = false;
            groupBoxLegal.Visible = false;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegisterNewInsuranceCase_Click(object sender, EventArgs e)
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

        private void InsurerWelcome_Load(object sender, EventArgs e)
        {

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

        private void showAllClientPayments_Click_1(object sender, EventArgs e)
        {

        }

        private void showAllPoliceCategoriesAndCases_Click_1(object sender, EventArgs e)
        {

        }
        private void registerClientButton_Click(object sender, EventArgs e)
        {
            RegisterClient cw = new RegisterClient();
            cw.Show();
            this.Close();
        }

        private void formPolice_Click(object sender, EventArgs e)
        {
            RegisterPolice cw = new RegisterPolice();
            cw.Show();
            this.Close();
        }

        private void clientType_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBoxIndividual.Visible = false;
            groupBoxLegal.Visible = false;
            if (clientType.SelectedItem.Equals("юр. лицо"))
            {
                groupBoxLegal.Visible = true;
                
                //add all legal client's companies to dropdown
                GetAllLegalClientsInfo command1 = new GetAllLegalClientsInfo();
                List<LegalPerson> legalPersonList = command1.getAllLegalPersonInfo();
                companyComboBox.Items.AddRange(legalPersonList.ToArray());

                //add all police categories
                GetAllInsuranceCategoriesCommand command2 = new GetAllInsuranceCategoriesCommand();
                List<InsuranceCategory> categoryList = command2.getAllInsuranceCategories();
                policeCategoryComboBox.Items.AddRange(categoryList.ToArray());

                //add insurer names to dropdown
                GetAllInsurers command3 = new GetAllInsurers();
                List<Insurer> insurerList = command3.getAllInsurers();
                insurerComboBox.Items.AddRange(insurerList.ToArray());
                
            }
            if (clientType.SelectedItem.Equals("физ. лицо"))
            {
                groupBoxIndividual.Visible = true;

                //add all individual clients fsl to dropdown
                GetAllIndividualClients command1 = new GetAllIndividualClients();
                List<Individual> individualList = command1.getAllLegalPersonInfo();
                fslNameIndividualComboBox.Items.AddRange(individualList.ToArray());

                //add all police categories
                GetAllInsuranceCategoriesCommand command2 = new GetAllInsuranceCategoriesCommand();
                List<InsuranceCategory> categoryList = command2.getAllInsuranceCategories();
                policeCategoryIndividualComboBox.Items.AddRange(categoryList.ToArray());

                //add insurer names to dropdown
                GetAllInsurers command3 = new GetAllInsurers();
                List<Insurer> insurerList = command3.getAllInsurers();
                insurerIdIndividualComboBox.Items.AddRange(insurerList.ToArray());
            }
        }

        private void groupBoxIndividual_Enter(object sender, EventArgs e)
        {

        }

        private void registerClient_Click(object sender, EventArgs e)
        {
            RegisterClient cw = new RegisterClient();
            cw.Show();
            this.Close();
        }

        private void registerPoliceMenu_Click(object sender, EventArgs e)
        {
            RegisterPolice cw = new RegisterPolice();
            cw.Show();
            this.Close();
        }

//legal person
        private void registerLegalPersonLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterClient cw = new RegisterClient();
            cw.Show();
            //groupBoxLegal.Visible = true;
        }

        private void insurerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void policeCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void policeCoastNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void policeAmountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void startDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void endDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void submitLegal_Click(object sender, EventArgs e)
        {
            InsurancePolicy policy = new InsurancePolicy();
            LegalPerson client = new LegalPerson();
            client = (LegalPerson)companyComboBox.SelectedItem;
            policy.Client = client;
            policy.Insurer = (Insurer)insurerComboBox.SelectedItem;
            policy.Category = (InsuranceCategory)policeCategoryComboBox.SelectedItem;
            policy.Cost = policeCoastNumericUpDown.Value;
            policy.Amount = policeAmountNumericUpDown.Value;
            policy.SignDate = startDateDateTimePicker.Value;
            policy.ExpirationDate = endDateDateTimePicker.Value;

            RegisterNewPolice command = new RegisterNewPolice();
            bool result = command.registerNewPolice(policy);
        }
//

//individual
        private void insurerIdIndividualComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void policeCategoryIndividualComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fslNameIndividualComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void policeCoastIndividualNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void policeAmountIndividualNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void startDateIndividualDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void endDateIndividualDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonIndividual_Click(object sender, EventArgs e)
        {
            InsurancePolicy policy = new InsurancePolicy();
            Individual client = new Individual();
            client = (Individual)fslNameIndividualComboBox.SelectedItem;
            policy.Client = client;
            policy.Insurer = (Insurer)insurerIdIndividualComboBox.SelectedItem;
            policy.Category = (InsuranceCategory)policeCategoryIndividualComboBox.SelectedItem;
            policy.Cost = policeCoastIndividualNumericUpDown.Value;
            policy.Amount = policeAmountIndividualNumericUpDown.Value;
            policy.SignDate = startDateIndividualDateTimePicker.Value;
            policy.ExpirationDate = endDateIndividualDateTimePicker.Value;

            RegisterNewPolice command = new RegisterNewPolice();
            bool result = command.registerNewPolice(policy);
        }

        private void registerIndividuaLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterClient cw = new RegisterClient();
            cw.Show();
            //groupBoxIndividual.Visible = true;
        }

       
    }
}
