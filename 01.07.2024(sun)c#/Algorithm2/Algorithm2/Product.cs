using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Algorithm2
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
    }
    public class Programs
    {
        public static void Main()
        {
            List<Product> list = new List<Product>
            {
                new Product { Id = 1,Name="laptop",Category="electronics",Price=15000 },
                new Product { Id = 2,Name="phone",Category="electronics",Price=10000 },
                new Product{Id=3,Name="Table",Category="furniture",Price=2000},
                new Product{Id=4,Name="Pen",Category="stationery",Price=40}

            };
            //q1
            var list1 = from p in list where p.Category == "electronics" select p;
            foreach (var p in list1)
            {
                Console.WriteLine(p.Name);

            }

            //q2
            var list2 = from p in list select p.Name;
            foreach (var p in list2) {
                Console.WriteLine(p);
            }
            //q3
            var product5 = from p in list select p.Name;
            foreach (var electronic in product5)
                foreach (var item in electronic)
                {
                    Console.WriteLine(item);
                }
            {

            }
            Console.WriteLine("--------");
            //q4
            var words = from word in list group word by word.Category;
            foreach (var word in words) {
                Console.WriteLine(word.Key);

                foreach (var word2 in word) {
                    Console.WriteLine(word2.Name);
                }
            }
            Console.WriteLine("--------");
            //q5
            var product2 = list.OrderBy(p => p.Price);
            foreach (var product in product2) {
                Console.WriteLine(product.Name);
            }
            Console.WriteLine("--------");
            //q6
            var product4 = list.OrderBy(p => p.Category).ThenBy(p => p.Price);
            foreach (var product in product4)
            {
                Console.Write(product.Name);
            }
            Console.WriteLine("---------");

            //q7
            var product3 = list.OrderByDescending(p => p.Price);
            foreach (var product in product3) {
                Console.WriteLine(product.Name);
            }
            Console.WriteLine("--------");
            //q8

            var product6 = list.OrderByDescending(p => p.Category).ThenBy(p => p.Price);
            foreach (var product in product6)
            {
                Console.Write(product.Name);
            }

            Console.WriteLine("--------");
            //q9
            var list3 = list.Select(p => p.Name).ToList();
            // Console.WriteLine(list3.GetType());
            foreach (var item in list3) {
                Console.WriteLine(item);
            }
            Console.WriteLine("----");
            //q10
            var convertarray = list.Select(p => p.Name).ToArray();
            //Console.WriteLine(convertarray);
            foreach (var item in convertarray) {
                Console.WriteLine(item);
            } Console.WriteLine("-------");

            //q20
            //var list4 = from p in list select p.Price;
            //foreach (var p in list4)
            // {
            // Console.WriteLine(p);
            // }
           // var pro = list.Select(p => p.Category);
        //Console.WriteLine("------==");
            //q11
            var product11 = list.Select(p => new{p.Name});
            var product12 = list.Select(a => new {a.Name });
            var lis=product11.Union(product12);

            Console.WriteLine(lis.Count());
            //q12
             var product13 = list.Select(p => new { p.Name });
            var product14 = list.Select(a => new { a.Name });
            var lis1 = product13.Except(product14).ToList();


            Console.WriteLine(lis1.Count());
            foreach (var item in lis1)
            { Console.WriteLine(item.Name); }

            //q13
            var product15 = list.Select(p => new { p.Category });
            var product16 = product15.Distinct().ToList();
          


            
            foreach (var item in product16)
            { Console.WriteLine(item.Category); }
            //q14
            var product18 = list.Select(p => new { p.Name });
            var product17 = list.Select(a => new { a.Name });
            var lis3 = product13.Intersect(product14).ToList();
            
            Console.Write(lis1.Count());
            Console.WriteLine("------");
           
            //q15
            var firProduct=list.FirstOrDefault();
            Console.WriteLine(firProduct.Name);
            //q16
            var firProducts = list.LastOrDefault();
            Console.WriteLine(firProducts.Name);
            //q23
            // var fproduct=list.Min(a => a.Price).FirstOrDefault();
            // var minPriceProduct = list.OrderBy(p => p.Price).Min();
            // Console.WriteLine("hjhj"+minPriceProduct);
            var produc = list.Min(a => a.Price);
            Console.WriteLine(produc);
            //q24
            var product19=list.Max(a => a.Price);
            
           Console.WriteLine(product19);
           //foreach (var items in product19)
           //q21
           var fpro=list.Sum(a => a.Price);


            Console.WriteLine("Ttotal is"+fpro);
            
            //22

            var fpro1 = list.Average(a => a.Price);
            
            Console.WriteLine("Average is:"+fpro1);
            //25
            // bool pro = list.Contains();
            // Console.WriteLine(pro);
            //var pro=list.SingleOrDefault(a => a.Name==list.); 
           










                    Console.ReadLine();
        }
        

    }
}
