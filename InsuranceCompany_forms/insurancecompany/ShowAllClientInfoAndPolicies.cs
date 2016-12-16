using InsuranceCompany.entity;
using InsuranceCompany.insuranceCompany.command;
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
    public partial class ShowAllClientInfoAndPolicies : Form
    {
        private BindingList<InsurancePolicy> legalPolicyBindList;
        private BindingList<InsurancePolicy> individualPolicyBindList;
        

        public ShowAllClientInfoAndPolicies()
        {
            InitializeComponent();

            dataGridView1.Visible = false;
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
                List<Individual> individualList = command.getAllLegalPersonInfo();
                name.Items.AddRange(individualList.ToArray());
            }
        }

        private void name_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            if (clientType.SelectedItem.Equals("юр. лицо"))
            {
                LegalPerson legalPerson = (LegalPerson)name.SelectedItem;
                GetAllLegalPersonPoliciesCommand command = new GetAllLegalPersonPoliciesCommand();
                List<InsurancePolicy> legalPolicyList = command.getAllLegalPersonPolicies(legalPerson);



                dataGridView1.Columns.Add("CategoryName", "Категория");
                dataGridView1.Columns.Add("PolicyCost", "Стоимость полиса");
                dataGridView1.Columns.Add("PolicyAmount", "Сумма полиса");
                dataGridView1.Columns.Add("SignDate", "Дата закл. договора");
                dataGridView1.Columns.Add("ExpDate", "Дата оконч. договора");
                dataGridView1.Columns.Add("Insurer", "Страховщик");
                dataGridView1.Columns.Add("CaseList", "Страховые случаи");

                dataGridView1.Rows.Clear();
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.Dock = DockStyle.Fill;

                legalPolicyBindList = new BindingList<InsurancePolicy>(legalPolicyList);

                foreach (InsurancePolicy policy in legalPolicyBindList)
                {
                    int rowNumber = dataGridView1.Rows.Add();

                    dataGridView1.Rows[rowNumber].Cells["CategoryName"].Value = policy.Category.Name;
                    dataGridView1.Rows[rowNumber].Cells["PolicyCost"].Value = policy.Cost;
                    dataGridView1.Rows[rowNumber].Cells["PolicyAmount"].Value = policy.Amount;
                    dataGridView1.Rows[rowNumber].Cells["SignDate"].Value = policy.SignDate;
                    dataGridView1.Rows[rowNumber].Cells["ExpDate"].Value = policy.ExpirationDate;
                    dataGridView1.Rows[rowNumber].Cells["Insurer"].Value = policy.Insurer.Name + " " + policy.Insurer.SecondName + " " + policy.Insurer.Surname;

                    String cases = "";
                    foreach (InsuranceCase cs in policy.InsuranceCaseList)
                    {
                        cases = cases + cs.InsuranceCaseName + " ";
                    }

                    dataGridView1.Rows[rowNumber].Cells["CaseList"].Value = cases;
                }
                clientType.Visible = false;
                name.Visible = false;

            }
            if (clientType.SelectedItem.Equals("физ. лицо"))
            {
                Individual individualPerson = (Individual)name.SelectedItem;
                GetAllIndividualPoliciesCommand command = new GetAllIndividualPoliciesCommand();
                List<InsurancePolicy> individualPolicyList = command.getallIndividualPolicies(individualPerson);

                dataGridView1.Columns.Add("CategoryName", "Категория");
                dataGridView1.Columns.Add("PolicyCost", "Стоимость полиса");
                dataGridView1.Columns.Add("PolicyAmount", "Сумма полиса");
                dataGridView1.Columns.Add("SignDate", "Дата закл. договора");
                dataGridView1.Columns.Add("ExpDate", "Дата оконч. договора");
                dataGridView1.Columns.Add("Insurer", "Страховщик");
                dataGridView1.Columns.Add("CaseList", "Страховые случаи");

                dataGridView1.Rows.Clear();
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.Dock = DockStyle.Fill;

                individualPolicyBindList = new BindingList<InsurancePolicy>(individualPolicyList);

                foreach (InsurancePolicy policy in individualPolicyBindList)
                {
                    int rowNumber = dataGridView1.Rows.Add();

                    dataGridView1.Rows[rowNumber].Cells["CategoryName"].Value = policy.Category.Name;
                    dataGridView1.Rows[rowNumber].Cells["PolicyCost"].Value = policy.Cost;
                    dataGridView1.Rows[rowNumber].Cells["PolicyAmount"].Value = policy.Amount;
                    dataGridView1.Rows[rowNumber].Cells["SignDate"].Value = policy.SignDate;
                    dataGridView1.Rows[rowNumber].Cells["ExpDate"].Value = policy.ExpirationDate;
                    dataGridView1.Rows[rowNumber].Cells["Insurer"].Value = policy.Insurer.Name + " " + policy.Insurer.SecondName + " " + policy.Insurer.Surname;

                    String cases = "";
                    foreach (InsuranceCase cs in policy.InsuranceCaseList)
                    {
                        cases = cases + cs.InsuranceCaseName + " ";
                    }

                    dataGridView1.Rows[rowNumber].Cells["CaseList"].Value = cases;
                }
                clientType.Visible = false;
                name.Visible = false;
            }
        }

        private void ShowAllClientsInfo_Click_1(object sender, EventArgs e)
        {
            ShowAllClientInfoAndPolicies cw = new ShowAllClientInfoAndPolicies();
            cw.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
