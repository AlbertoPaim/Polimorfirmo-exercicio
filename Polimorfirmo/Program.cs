using Polimorfirmo.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Curse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of products:");
            int numberOfProducts = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 0; i < numberOfProducts; i++) {

                Console.WriteLine("Common, used or imported (c/u/i):");
                string productCategory = Console.ReadLine().ToUpper();

                Console.WriteLine("name:");
                string name = Console.ReadLine();

                Console.WriteLine("Price:");
                double price = double.Parse(Console.ReadLine());

                if (productCategory == "C")
                {
                    products.Add(new Product { Name = name, Price = price });
                }
                else if (productCategory == "U") {
    
                    DateTime date = DateTime.Now;
                    products.Add(new UsedProduct { Name = name, Price = price, ManufactureDate = date });

                }
                else if (productCategory == "I")
                {
                    Console.WriteLine("Customs fee");
                    double fee = double.Parse(Console.ReadLine());

                    products.Add(new ImportedProduct { Name = name, Price = price, CustomsFee = fee });
                } else
                {
                    Console.WriteLine("Category doesn't exists! please try again (c/u/i) ");
                }
                

            }

            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTage());
            }


        }
    }
}