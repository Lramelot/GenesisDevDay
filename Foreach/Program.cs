using System;
using System.Collections.Generic;
using System.Linq;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Indéfini" },
                new Product { Id = 2, Name = "Indéfini" },
                new Product { Id = 3, Name = "Indéfini" },
                new Product { Id = 4, Name = "Indéfini" }
            };

            var productsCatalog = new List<Product>
            {
                new Product { Id = 1, Name = "iPhone X" },
                new Product { Id = 2, Name = "PS4" },
                new Product { Id = 3, Name = "Pain frais" },
                new Product { Id = 4, Name = "Ciment" }
            };

            Console.WriteLine("==== Produits avant calcul TVA ====");
            DisplayProducts(products);

            // Recherche des informations dans le catalogue
            products.ForEach(product => product = productsCatalog.Single(p => p.Id == product.Id);
            
            Console.WriteLine();
            Console.WriteLine("==== Produits après calcul TVA ====");
            DisplayProducts(products);

            Console.ReadKey();
        }

        public static void DisplayProducts(IEnumerable<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine($"L'identifiant ${product.Id} a pour nom {product.Name}");
            }
        }

        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
