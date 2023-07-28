namespace ClassMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Kübra";
            customer1.Address = "Bursa";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Necati";
            customer2.Address = "Manisa";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Merve";
            customer3.Address = "Muş";

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.Name = "Can";
            customer4.Address = "Malatya";


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