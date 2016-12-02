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
    public partial class ClientWelcome : Form
    {
        public ClientWelcome()
        {
            InitializeComponent();
        }

        private void formNewPolice_Click(object sender, EventArgs e)
        {
            FormNewPolice fnp = new FormNewPolice();
            fnp.Show();
        }

        private void getClientInfo_Click(object sender, EventArgs e)
        {
            ClientInfo ci = new ClientInfo();
            ci.Show();
            this.Close();
        }

        private void formPaymentRequest_Click(object sender, EventArgs e)
        {
            FormPaymentRequest fpr = new FormPaymentRequest();
            fpr.Show();
        }
    }
}
