namespace ClassMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Ferhat";
            customer1.Address = "Konya";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Faruk";
            customer2.Address = "Samsun";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Fatih";
            customer3.Address = "Kayseri";

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.Name = "Muhammet";
            customer4.Address = "Samsun";


            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };

            CustomerManager customerManager = new CustomerManager();


            for (int i = 0; i < customers.Length; i++)
            {
                customerManager.AddCustomer(customers[i]);
                customerManager.listCustomer(customers[i]);
            }
        }
    }
}