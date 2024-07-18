namespace ACME_Web_App
{
    public class CustomerManager
    {
        private ArrayList customers = new ArrayList();

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine(DisplayAllCustomers());
        }

        public ArrayList GetCustomers()
        {
            return customers;
        }

        public string DisplayCustomerInfo(Customer customer)
        {
            return $"Name: {customer.Name}\tAddress: {customer.Address}\tIs capable of loading? {(customer.IsCapableOfLoading ? "Yes" : "No")}\tDelivery Hours: {customer.DeliveryHours}";
        }

        public string DisplayAllCustomers()
        {
            string list = "";
            foreach (Customer customer in customers)
            {
                list += DisplayCustomerInfo(customer);
                list += "\n";
            }
            return list;
        }
    }
}
