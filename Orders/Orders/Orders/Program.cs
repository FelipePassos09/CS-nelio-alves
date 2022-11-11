using System;
using System.Globalization;
using Orders.Entities;
using Orders.Entities.Enums;

namespace Orders
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Colecting client data:
            Console.WriteLine("Enter Client data:");
            Console.Write("Client Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Client Birth (DD/MM/YYYY): ");
            DateTime clientBirth = DateTime.Parse(Console.ReadLine());
            
            // Collecting order data:
            Console.WriteLine("Enter order data:");
            Console.Write("Order Status \n(PendingPayment / Processing / Shipped / Delivered)\n: ");
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus),Console.ReadLine());
            Console.Write("How many items to this order? ");
            int orderQuantity = int.Parse(Console.ReadLine());
            
            // Intance Order data:
            Order balconist = new Order
            {
                Client = new Client(name: clientName, email: clientEmail, birth_date: clientBirth),
                OrderDate = DateTime.Now,
                Status = status
                
            };

            // Collecting item(s) data:
            for (int i = 0; i < orderQuantity; i++)
            {
                Console.WriteLine($"Enter Item #{i + 1} data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Unit price item: ");
                double productUnitPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity of items: ");
                int quantityProducts = int.Parse(Console.ReadLine());
                
                // Instace item data:

                OrderItem item = new OrderItem
                {
                    Price = productUnitPrice,
                    Quantity = quantityProducts,
                    Product = new Product(productName, productUnitPrice)
                };
                
                balconist.AddItem(item);
                
            }
            
            // Returning order summary:
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine($"Oder Date: {balconist.OrderDate}");
            Console.WriteLine($"Order Status: {balconist.Status}");
            Console.WriteLine($"Client Name: {balconist.Client.Name}");
            Console.WriteLine($"ORDER ITEMS:");
            foreach (var item in balconist.Items)
            {
                Console.WriteLine($"{item.Product.ToString()}");
            }
            Console.WriteLine($"Total Cost: {balconist.TotalAmmount()}");

        }
    }
}