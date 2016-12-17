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
    public partial class ShowAllClientsPayments : Form
    {
        public ShowAllClientsPayments()
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

        private void name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clientType.SelectedItem.Equals("юр. лицо"))
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.Dock = DockStyle.Fill;

                GetAllLegalPersonPolicyPayments command = new GetAllLegalPersonPolicyPayments();
                List<PolicyPayment> list = command.getAllLegalPersonPolicyPayments((LegalPerson)name.SelectedItem);
                BindingList<PolicyPayment> caseList = new BindingList<PolicyPayment>(list);

                dataGridView1.Columns.Add("Client", "Клиент");
                dataGridView1.Columns.Add("PolicyCategory", "Категория полиса");
                dataGridView1.Columns.Add("PaymentDate", "Дата выплаты");
                dataGridView1.Columns.Add("PaymentAmount", "Сумма выплаты");
                foreach (PolicyPayment l in caseList)
                {
                    int rowNumber = dataGridView1.Rows.Add();

                    dataGridView1.Rows[rowNumber].Cells["Client"].Value = ((LegalPerson)name.SelectedItem).CompanyName;
                    dataGridView1.Rows[rowNumber].Cells["PolicyCategory"].Value = l.Policy.Category;
                    dataGridView1.Rows[rowNumber].Cells["PaymentDate"].Value = l.PaymentDate;
                    dataGridView1.Rows[rowNumber].Cells["PaymentAmount"].Value = l.PaymentAmount;
                }
            }
            if (clientType.SelectedItem.Equals("физ. лицо"))
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.Dock = DockStyle.Fill;

                GetAllIndividualPolicyPayments command = new GetAllIndividualPolicyPayments();
                List<PolicyPayment> list = command.getAllIndividualPolicyPayments((Individual)name.SelectedItem);
                BindingList<PolicyPayment> caseList = new BindingList<PolicyPayment>(list);

                dataGridView1.Columns.Add("Client", "Клиент");
                dataGridView1.Columns.Add("PolicyCategory", "Категория полиса");
                dataGridView1.Columns.Add("PaymentDate", "Дата выплаты");
                dataGridView1.Columns.Add("PaymentAmount", "Сумма выплаты");
                foreach (PolicyPayment l in caseList)
                {
                    int rowNumber = dataGridView1.Rows.Add();

                    dataGridView1.Rows[rowNumber].Cells["Client"].Value = ((Individual)name.SelectedItem).Surname + " "+ ((Individual)name.SelectedItem).Name + " " + ((Individual)name.SelectedItem).SecondName;
                    dataGridView1.Rows[rowNumber].Cells["PolicyCategory"].Value = l.Policy.Category;
                    dataGridView1.Rows[rowNumber].Cells["PaymentDate"].Value = l.PaymentDate;
                    dataGridView1.Rows[rowNumber].Cells["PaymentAmount"].Value = l.PaymentAmount;
                }
            }
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

        private void data_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
