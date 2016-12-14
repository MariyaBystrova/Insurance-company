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
    public partial class RegisterClient : Form
    {
        public RegisterClient()
        {
            InitializeComponent();
            groupBoxIndividual.Visible = false;
            groupBoxLegal.Visible = false;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegisterClient_Load(object sender, EventArgs e)
        {

        }

        private void clientType_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBoxIndividual.Visible = false;
            groupBoxLegal.Visible = false;
            if (clientType.SelectedItem.Equals("legal"))
            {
                groupBoxLegal.Visible = true;
            }
            if (clientType.SelectedItem.Equals("individual"))
            {
                groupBoxIndividual.Visible = true;
            }
        }

        private void registerClientButton_Click(object sender, EventArgs e)
        {
            RegisterClient cw = new RegisterClient();
            cw.Show();
            this.Close();
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

        private void formPolice_Click(object sender, EventArgs e)
        {
            RegisterPolice cw = new RegisterPolice();
            cw.Show();
            this.Close();
        }

        private void registerNewInsuranceCase_Click_1(object sender, EventArgs e)
        {
            FormNewInsuranceCase cw = new FormNewInsuranceCase();
            cw.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void submitLegalPerson_Click(object sender, EventArgs e)
        {
            //companyName
            //textBox2
            //directorName
            //textBox1

        }

        private void companyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void directorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
