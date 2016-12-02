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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void client_Click(object sender, EventArgs e)
        {
            ClientWelcome cw = new ClientWelcome();
            cw.Show();
      
        }

        private void insurer_Click(object sender, EventArgs e)
        {
            InsurerWelcome iw = new InsurerWelcome();
            iw.Show();
        }

        private void clientMenu_Click(object sender, EventArgs e)
        {

        }

        private void legalMenu_Click(object sender, EventArgs e)
        {

        }

        private void clientMenu_Click_1(object sender, EventArgs e)
        {

        }

        private void insurerMenu_Click(object sender, EventArgs e)
        {
            InsurerWelcome iw = new InsurerWelcome();
            iw.Show();
        }

    }
}
