using System;
using System.Collections;
using System.Windows.Forms;

namespace ACME_Web_App
{
    public partial class EditCustomerForm : Form
    {
        private ArrayList customers;

        public EditCustomerForm(ArrayList customers)
        {
            InitializeComponent();
            this.customers = customers;
            DisplayCustomers();
        }

        private void DisplayCustomers()
        {
            listBoxCustomers.Items.Clear();
            foreach (Customer customer in customers)
            {
                listBoxCustomers.Items.Add(customer.ToString());
            }
        }
    }
}
