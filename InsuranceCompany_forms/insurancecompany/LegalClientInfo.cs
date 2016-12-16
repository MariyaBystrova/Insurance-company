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
    public partial class LegalClientInfo : Form
    {
        public LegalClientInfo()
        {
            InitializeComponent();

            GetAllLegalClientsInfo command = new GetAllLegalClientsInfo();
            List<LegalPerson> legalPersonList = command.getAllLegalPersonInfo();
            name.Items.AddRange(legalPersonList.ToArray());
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

        private void LegalClientInfo_Load(object sender, EventArgs e)
        {

        }

        private void name_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowRichText cw = new ShowRichText();
            cw.Client = (LegalPerson)name.SelectedItem;
            cw.Show();
        }
    }
}
