using System;
using System.Windows.Forms;

namespace ACME_Web_App
{
    public partial class PortalScreen : Form
    {
        public PortalScreen()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer Portal button clicked.");
        }
    }
}
