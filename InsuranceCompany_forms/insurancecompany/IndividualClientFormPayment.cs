using InsuranceCompany.entity;
using InsuranceCompany.insuranceCompany.command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceCompany
{
    public partial class IndividualClientFormPayment : Form
    {
        public IndividualClientFormPayment()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void getClientInfo_Click(object sender, EventArgs e)
        {
            IndividualClientInfo cw = new IndividualClientInfo();
            cw.Show();
            this.Close();
        }

        private void formPaymentRequest_Click(object sender, EventArgs e)
        {
            IndividualClientFormPayment cw = new IndividualClientFormPayment();
            cw.Show();
            this.Close();
        }

        private void policeNumberInput_TextChanged(object sender, EventArgs e)
        {
            insuranseCaseInput.Items.Clear();
            Regex regex = new Regex("[1-9]{1}[0-9]*");

            if (regex.IsMatch(policeNumberInput.Text))
            {
                GetAllIndividualPoliciesCommand command = new GetAllIndividualPoliciesCommand();
                int individualClientId = Int32.Parse(policeNumberInput.Text);
                Individual individualPerson = new Individual();
                individualPerson.Id = individualClientId;
                List<InsurancePolicy> policyList = command.getallIndividualPolicies(individualPerson);
                foreach (InsurancePolicy policy in policyList)
                {
                    insuranseCaseInput.Items.AddRange(policy.InsuranceCaseList.ToArray());
                }
            }
        }

        private void insuranseCaseInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void submitPaymentRequest_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(policeNumberInput.Text) || insuranseCaseInput.SelectedItem==null)
            {
                label1.Text = "Проверьте заполнение всех полей.";
            }
            else
            {
                InsuranceCase insuranceCase = (InsuranceCase)insuranseCaseInput.SelectedItem;
                int individualClientId = Int32.Parse(policeNumberInput.Text);
                RegisterNewIndividualPaymentRequest command = new RegisterNewIndividualPaymentRequest();
                bool result = command.registerNewIndividualPaymentRequest(insuranceCase, individualClientId);

                if (result == true)
                {
                    policeNumberInput.Clear();
                    insuranseCaseInput.ResetText();
                    
                    label1.Text = "Обращение за выплатой успешно зарегистрировано.";
                }
                if (result == false)
                {
                    label1.Text = "Не удалось зарегистрировать обращение.";
                }
            }
        }

        private void groupBoxFormPayment_Enter(object sender, EventArgs e)
        {

        }

    }
}
