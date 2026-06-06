using System;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            // ==========================================
            // ORDER 1: Domestic Order (USA Customer)
            // ==========================================
            Address address1 = new Address("123 Main St Apt 4B", "Philadelphia", "PA", "USA");
            Customer customer1 = new Customer("John Doe", address1);
            Order order1 = new Order(customer1);

            Product prod1 = new Product("Wireless Mouse", "M901", 25.50, 2);
            Product prod2 = new Product("Mechanical Keyboard", "K840", 79.99, 1);
            Product prod3 = new Product("Desk Mat XL", "D100", 15.00, 1);

            order1.AddProduct(prod1);
            order1.AddProduct(prod2);
            order1.AddProduct(prod3);

            // ==========================================
            // ORDER 2: International Order (Non-USA Customer)
            // ==========================================
            Address address2 = new Address("45 Herbert Macaulay Way", "Yaba", "Lagos", "Nigeria");
            Customer customer2 = new Customer("Seyi Bamgboye", address2);
            Order order2 = new Order(customer2);

            Product prod4 = new Product("USB-C Hub Multiport", "H300", 35.00, 1);
            Product prod5 = new Product("Noise Cancelling Headphones", "H-ANC2", 120.00, 1);

            order2.AddProduct(prod4);
            order2.AddProduct(prod5);

            // ==========================================
            // RENDER SYSTEM LOG REPORTS TO TERMINAL
            // ==========================================
            Console.WriteLine("==================================================");
            Console.WriteLine("           ONLINE ORDER PROCESSING SYSTEM         ");
            Console.WriteLine("==================================================\n");

            // Display Order 1 details
            Console.WriteLine(">>> PROCESSING ORDER #1 <<<");
            Console.Write(order1.GetShippingLabel());
            Console.WriteLine();
            Console.Write(order1.GetPackingLabel());
            Console.WriteLine($"Total Invoice Price (incl. shipping): ${order1.CalculateTotalOrderCost():F2}");
            Console.WriteLine("\n--------------------------------------------------\n");

            // Display Order 2 details
            Console.WriteLine(">>> PROCESSING ORDER #2 <<<");
            Console.Write(order2.GetShippingLabel());
            Console.WriteLine();
            Console.Write(order2.GetPackingLabel());
            Console.WriteLine($"Total Invoice Price (incl. shipping): ${order2.CalculateTotalOrderCost():F2}");
            Console.WriteLine("\n==================================================");
        }
    }
}