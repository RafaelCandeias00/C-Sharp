using Seção_9___Aula_123___Exercício.Entities.Enums;
using Seção_9___Aula_123___Exercício.Entities;
using System.Globalization;
using System;

namespace Seção_9___Aula_123___Exercício {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("--- Enter client data ---");
            Console.Write("Name: ");
            string nameClient = Console.ReadLine();

            Console.Write("Email: ");
            string emailClient = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDateClient = DateTime.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("--- Enter order data ---");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client clientData = new Client(nameClient, emailClient, birthDateClient);
            Order orderDate = new Order(DateTime.Now, status, clientData);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Enter {i} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Product productData = new Product(nameProduct, priceProduct);

                Console.Write("Quantity: ");
                int quantityProduct = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantityProduct, priceProduct, productData);
                orderDate.AddItems(orderItem);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(orderDate);

        }
    }
}
