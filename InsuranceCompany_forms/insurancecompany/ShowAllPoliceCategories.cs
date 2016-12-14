using InsuranceCompany.entity;
using InsuranceCompany.insuranceCompany.command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceCompany
{
    public partial class ShowAllPoliceCategories : Form
    {

        private BindingList<InsuranceCase> caseList;

        /*  public List<InsuranceCase> getCaseList() {
              return this.caseList;
          }
          public void setCaseList(List<InsuranceCase> caseList) {
              this.caseList = caseList;
          }*/
        public ShowAllPoliceCategories()
        {
            InitializeComponent();
            /*
            GetAllInsuranceCasesCommand command = new GetAllInsuranceCasesCommand();
            caseList = new BindingList<InsuranceCase>(command.getAllInsuranceCases());
            dataGridView1.DataSource = command.getAllInsuranceCases();*/
         
           // dataGridView1.DataSource = caseList;
           //  caseList = new List<InsuranceCase>();
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

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.Dock = DockStyle.Fill;

            GetAllInsuranceCasesCommand command = new GetAllInsuranceCasesCommand();
            caseList = new BindingList<InsuranceCase>(command.getAllInsuranceCases());

            dataGridView1.Columns.Add("CategoryName", "Категория");
            dataGridView1.Columns.Add("Name", "Название");
            dataGridView1.Columns.Add("PaymentProcent", "Процент выплат");
            foreach (InsuranceCase cs in caseList)
            {
                int rowNumber = dataGridView1.Rows.Add();

                dataGridView1.Rows[rowNumber].Cells["CategoryName"].Value = cs.InsuranceCategory.Name;
                dataGridView1.Rows[rowNumber].Cells["Name"].Value = cs.InsuranceCaseName;
                dataGridView1.Rows[rowNumber].Cells["PaymentProcent"].Value = cs.PaymentProcent;
            }

            button1.Visible = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
