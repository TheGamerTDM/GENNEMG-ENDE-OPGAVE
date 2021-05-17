using System;
using System.Collections.Generic;
using System.Linq;


namespace Aflevereing_til_17_05
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {


                Console.WriteLine("-------------");
                Console.WriteLine("WELLCOME :D");
                Console.WriteLine("-------------");
                Console.WriteLine("There are following optins");
                Console.WriteLine("1: Se vare");
                Console.WriteLine("2: Tilføj Vare");
                Console.WriteLine("3: Redegier Vare");
                Console.WriteLine("4: Slet vare");
                Console.Write("Vælg: ");
                string valg = Console.ReadLine();


                switch (Convert.ToInt32(valg))
                {
                    case 1:
                        Console.WriteLine();

                        foreach (var item in Product.products)
                        {
                            Console.WriteLine($"Product: {item.Name}   Count: {item.Count}    Id: {item.Id}");
                        }

                        Console.WriteLine();
                        break;
                    case 2:

                        Console.Clear();

                        Console.Write("Name: ");
                        string productName = Console.ReadLine();
                        Console.Write("Count: ");
                        string _count = Console.ReadLine();

                        Product p1 = new Product(productName, Convert.ToInt32(_count));
                        p1.Id = Product.products.Count + 1;
                        Product.products.Add(p1);

                        Console.Clear();

                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Væget id");
                        Console.WriteLine();
                        foreach (var item in Product.products)
                        {
                            Console.WriteLine($"Product: {item.Name}   Count: {item.Count}    Id: {item.Id}");
                        }
                        Console.WriteLine();
                        Console.Write("Vælg id: ");
                        string _valgAfEditId = Console.ReadLine();

                        Product product = Product.products.Single(i => i.Id == Convert.ToInt32(_valgAfEditId));

                        Console.Write("Ny Navn: ");
                        string newName = Console.ReadLine();
                        Console.Write("Ny Count: ");
                        int newCount = Convert.ToInt32(Console.ReadLine());
                        product.Name = newName;
                        product.Count = newCount;

                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Slet med id");
                        foreach (var item in Product.products)
                        {
                            Console.WriteLine($"Product: {item.Name}   Count: {item.Count}    Id: {item.Id}");
                        }
                        Console.Write("Vælg id: ");
                        string _valgAfSletId = Console.ReadLine();

                        Product.products.Remove(Product.products.Single(i => i.Id == Convert.ToInt32(_valgAfSletId)));

                        break;

                    default:
                        break;
                }
            }
        }
    }

    public class Product
    {
        public static List<Product> products = new List<Product>();

        private int id { get; set; }
        private string name;
        private int count;

        public int Count
        {
            get
            {
                return this.count;
            }
            set
            {
                this.count = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public Product()
        {
        }
        public Product(string pName, int pCount)
        {
            Name = pName;
            Count = pCount;
        }

        public void Edit(string Ename, int Ecount)
        {
            Name = Ename;
            count = Ecount;
        }
    }
}
