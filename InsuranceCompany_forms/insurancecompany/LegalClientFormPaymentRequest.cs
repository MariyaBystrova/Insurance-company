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
    public partial class LegalClientFormPaymentRequest : Form
    {
        public LegalClientFormPaymentRequest()
        {
            InitializeComponent();
        }

        private void FormPaymentRequest_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void getClientInfo_Click(object sender, EventArgs e)
        {
            LegalClientInfo ci = new LegalClientInfo();
            ci.Show();
            this.Close();
        }

        private void formPaymentRequest_Click(object sender, EventArgs e)
        {
            LegalClientFormPaymentRequest fpr = new LegalClientFormPaymentRequest();
            fpr.Show();
            this.Close();
        }

        private void policeNumberInput_TextChanged(object sender, EventArgs e)
        {
            insuranseCaseInput.Items.Clear();
            Regex regex = new Regex("[1-9]{1}[0-9]*");

            if (regex.IsMatch(policeNumberInput.Text))
            {
                GetAllLegalPersonPoliciesCommand command = new GetAllLegalPersonPoliciesCommand();
                int legalClientId = Int32.Parse(policeNumberInput.Text);
                LegalPerson legalPerson = new LegalPerson();
                legalPerson.Id = legalClientId;
                List<InsurancePolicy> policyList = command.getAllLegalPersonPolicies(legalPerson);
                foreach (InsurancePolicy policy in policyList)
                {
                    insuranseCaseInput.Items.AddRange(policy.InsuranceCaseList.ToArray());
                }
            }
        }

        private void submitPaymentRequest_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(policeNumberInput.Text) || insuranseCaseInput.SelectedItem == null)
            {
                label1.Text = "Проверьте заполнение всех полей.";
            }
            else
            {
                InsuranceCase insuranceCase = (InsuranceCase)insuranseCaseInput.SelectedItem;
                int legalClientId = Int32.Parse(policeNumberInput.Text);
                RegisterNewLegalPaymentRequest command = new RegisterNewLegalPaymentRequest();
                bool result = command.registerNewLegalPaymentRequest(insuranceCase, legalClientId);
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

    }
}
