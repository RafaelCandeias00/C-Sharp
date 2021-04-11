using Seção_10___Aula_133___Exercício.Entities;
using System.Collections.Generic;
using System.Globalization;
using System;

namespace Seção_10___Aula_133___Exercício {
    class Program {
        static void Main(string[] args) {
            List<Product> list = new List<Product>();

            Console.WriteLine();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine();

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char option = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: $");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(option == 'c' || option == 'C') {
                    list.Add(new Product(name, price));
                }else if (option == 'u' || option == 'U') {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime ManuDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, ManuDate));
                } else {
                    Console.Write("Custom fee: $");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("PRICE TAGS: ");
            foreach(Product pro in list) {
                Console.WriteLine(pro.PriceTag());
            }
        }
    }
}
