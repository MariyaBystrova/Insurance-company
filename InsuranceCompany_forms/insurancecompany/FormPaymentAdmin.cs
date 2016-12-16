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
    public partial class FormPaymentAdmin : Form
    {
        public FormPaymentAdmin()
        {
            InitializeComponent();

            reject.Visible = false;
            submit.Visible = false;

            GetAllIndividualWithPaymentRequests command = new GetAllIndividualWithPaymentRequests();
            List<Individual> individualList = command.getAllIndividualClientsWithPaymentRequests();

            listBox.Items.AddRange(individualList.ToArray());

            GetAllLegalPersonsWithPaymentRequests command2 = new GetAllLegalPersonsWithPaymentRequests();
            List<LegalPerson> legalList = command2.getAllLegalPersonsClientsWithPaymentRequests();
            listBox.Items.AddRange(legalList.ToArray());

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

        private void FormPaymentAdmin_Load(object sender, EventArgs e)
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

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem is LegalPerson)
            {
                label2.Text = "";
                LegalPerson client = (LegalPerson)listBox.SelectedItem;
                GetAllLegalPaymentRequestsCommand command = new GetAllLegalPaymentRequestsCommand();
                List<PolicyPayment> paymentList = command.getAllLegalPaymentRequests(client);

                label1.Text = "Компания: " + client.ToString();
                listBox.Items.Clear();
                listBox.Items.AddRange(paymentList.ToArray());

                reject.Visible = true;
                submit.Visible = true;
                button1.Visible = false;
            }
            if (listBox.SelectedItem is Individual)
            {
                label2.Text = "";

                Individual client = (Individual)listBox.SelectedItem;
                GetAllIndividualPaymentRequestsCommand command = new GetAllIndividualPaymentRequestsCommand();
                List<PolicyPayment> paymentList = command.getAllIndividualPaymentRequests(client);

                label1.Text = "ФИО: " + client.ToString();
                listBox.Items.Clear();
                listBox.Items.AddRange(paymentList.ToArray());

                reject.Visible = true;
                submit.Visible = true;
                button1.Visible = false;
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                SubmitPaymentRequestCommand command = new SubmitPaymentRequestCommand();
                bool result = command.submitPaymentRequest((PolicyPayment)listBox.SelectedItem);
                if (result)
                {
                    listBox.Items.Clear();
                    label2.Text = "Запрос на выплату подтвержден.";
                    GetAllIndividualWithPaymentRequests command1 = new GetAllIndividualWithPaymentRequests();
                    List<Individual> individualList = command1.getAllIndividualClientsWithPaymentRequests();
                    listBox.Items.AddRange(individualList.ToArray());

                    GetAllLegalPersonsWithPaymentRequests command2 = new GetAllLegalPersonsWithPaymentRequests();
                    List<LegalPerson> legalList = command2.getAllLegalPersonsClientsWithPaymentRequests();
                    listBox.Items.AddRange(legalList.ToArray());

                    label1.Text = "Все клиенты, оформившие обращение за выплатой";
                    reject.Visible = false;
                    submit.Visible = false;
                    button1.Visible = true;
                }
                else
                {
                    label2.Text = "Не удалось подтвердить запрос на выплату.";
                }
            }
        }

        private void reject_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                RejectPaymentRequestCommand command = new RejectPaymentRequestCommand();
                bool result = command.rejectPaymentRequest((PolicyPayment)listBox.SelectedItem);
                if (result)
                {
                    listBox.Items.Clear();
                    label2.Text = "Запрос на выплату отклонен.";
                    GetAllIndividualWithPaymentRequests command1 = new GetAllIndividualWithPaymentRequests();
                    List<Individual> individualList = command1.getAllIndividualClientsWithPaymentRequests();

                    listBox.Items.AddRange(individualList.ToArray());

                    GetAllLegalPersonsWithPaymentRequests command2 = new GetAllLegalPersonsWithPaymentRequests();
                    List<LegalPerson> legalList = command2.getAllLegalPersonsClientsWithPaymentRequests();
                    listBox.Items.AddRange(legalList.ToArray());

                    label1.Text = "Все клиенты, оформившие обращение за выплатой";
                    reject.Visible = false;
                    submit.Visible = false;
                    button1.Visible = true;
                }
                else
                {
                    label2.Text = "Не удалось отклонить запрос на выплату.";
                }
            }
        }
    }
}
