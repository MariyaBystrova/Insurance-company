﻿using System;
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
    public partial class IndividualClientWelcome : Form
    {
        public IndividualClientWelcome()
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
    }
}
