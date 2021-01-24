using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Müşterinin özelliklerini belirle. TcNo - Ad - Soyad - Yaş
            Customer customer1 = new Customer();
            customer1.TcNo = "11111111111";
            customer1.CustomerName = "Selim";
            customer1.CustomerSurname = "Pusat";
            customer1.CustomerAge = "35";

            Customer customer2 = new Customer();
            customer2.TcNo = "22222222222";
            customer2.CustomerName = "Barış";
            customer2.CustomerSurname = "Canöz";
            customer2.CustomerAge = "49";

            Customer customer3 = new Customer();
            customer3.TcNo = "33333333333";
            customer3.CustomerName = "Savaş";
            customer3.CustomerSurname = "Özcan";
            customer3.CustomerAge = "24";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customer = new CustomerManager();

            Console.WriteLine("Welcome to our Bank!");
            Console.WriteLine("Please select the action you want to do." + "\n" +
                " 0-Exit" + "\n" +
                " 1-Add" + "\n" +
                " 2-Delete " + "\n" +
                " 3-Update " + "\n" +
                " 4-List " + "\n ");

            while (true)
            {
                Console.WriteLine("Please Choose: ");
                int choice = Convert.ToInt16(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Exiting...");
                        break;
                    case 1:
                        customer.Add(customer1);
                        customer.Add(customer2);
                        customer.Add(customer3);
                        break;
                    case 2:
                        customer.Delete(customer1);
                        customer.Delete(customer2);
                        customer.Delete(customer3);
                        break;
                    case 3:
                        customer.Update(customer1);
                        customer.Update(customer2);
                        customer.Update(customer3);
                        break;
                    case 4:
                        customer.List(customers);
                        break;

                    default:
                        Console.WriteLine("Please make a valid selection.");
                        break;

                }
            }


        }
    }
}
