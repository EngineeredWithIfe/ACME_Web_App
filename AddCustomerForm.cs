using System;
using System.Windows.Forms;

namespace ACME_Web_App
{
    public partial class AddCustomerForm : Form
    {
        public CustomerManager customerManager = new CustomerManager();

        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string address = addressTextBox.Text;
            bool isCapableOfLoading = isCapableOfLoadingCheckBox.Checked;
            string deliveryHours = deliveryHoursTextBox.Text;

            Customer customer = new Customer(name, address, isCapableOfLoading, deliveryHours);

            customerManager.AddCustomer(customer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditCustomerForm editCustomerForm = new EditCustomerForm(customerManager.GetCustomers());
            editCustomerForm.Show();
        }
    }
}
