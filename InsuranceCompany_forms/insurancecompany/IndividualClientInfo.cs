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
    public partial class IndividualClientInfo : Form
    {
        public IndividualClientInfo()
        {
            InitializeComponent();

            GetAllIndividualClients command = new GetAllIndividualClients();
            List<Individual> individualList = command.getAllLegalPersonInfo();
            name.Items.AddRange(individualList.ToArray());
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

        private void name_SelectedIndexChanged(object sender, EventArgs e)
        {
           // name.SelectedItem.Equals();
        }
    }
}
