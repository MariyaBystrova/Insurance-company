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
            }
            if (clientType.SelectedItem.Equals("физ. лицо"))
            {
                groupBoxIndividual.Visible = true;
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

        }

        private void registerIndividuaLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

       
    }
}
