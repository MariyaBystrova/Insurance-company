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
    public partial class LegalClientWelcome : Form
    {
        public LegalClientWelcome()
        {
            InitializeComponent();
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

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
