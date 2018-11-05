using System;
using System.Collections.Generic;
using System.Linq;

namespace Foreach
{
    class Program
    {
        /// <summary>
        /// On souhaite récupéerer les différentes informations des produits du panier (cart)
        /// à partir de la collection du catalogue (productsCatalog).
        ///
        /// Cependant, la collection que l'on récupère semble identique. Pourquoi,
        /// comment régler ce problème ?
        /// </summary>
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Indéfini" },
                new Product { Id = 2, Name = "Indéfini" },
                new Product { Id = 3, Name = "Indéfini" },
            };

            var productsCatalog = new List<Product>
            {
                new Product { Id = 1, Name = "iPhone X" },
                new Product { Id = 2, Name = "PS4" },
                new Product { Id = 3, Name = "Pain frais" },
                new Product { Id = 4, Name = "Ciment" }
            };

            Console.WriteLine("==== Produits avant remplissage catalogue ====");
            DisplayProducts(products);

            // Attention que l'on souhaite conserver cette logique de remplacement
            // dans le foreach.

            // Recherche des informations dans le catalogue
            products.ForEach(product => product = productsCatalog.Single(p => p.Id == product.Id));
            
            Console.WriteLine();
            Console.WriteLine("==== Produits après remplissage catalogue ====");
            DisplayProducts(products);

            Console.ReadKey();
        }

        // /!\ Ne rien changer en dessous de ce commentaire
        public static void DisplayProducts(IEnumerable<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine($"L'identifiant {product.Id} a pour nom {product.Name}");
            }
        }

        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
