using Demo01.Data;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using static Demo01.ListGenerator;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace LINQTask02
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Aggregate Operators

            #region Q1
            //1.Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(num => num % 2 == 1);
            //Console.WriteLine(result);
            #endregion

            #region Q2
            //2. Return a list of customers and how many orders each has.
            //var result = CustomerList.Select(Customer => new
            //{
            //    CustomerID = Customer.CustomerID,
            //    OrdersCount = Customer.Orders.Count()
            //});

            //foreach (var order in result)
            //{
            //    Console.WriteLine(order);
            //}

            #endregion

            #region Q3
            //3. Return a list of categories and how many products each has
            //var result = ProductList.GroupBy(proudct => proudct.Category)
            //                        .Select(group => new
            //                        {
            //                            Category = group.Key,          
            //                            ProductCount = group.Count()   
            //                        });

            //foreach (var proudct in result)
            //{
            //    Console.WriteLine(proudct);

            //}
            #endregion

            #region Q4
            //4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count();
            //Console.WriteLine(result);

            #endregion

            #region Q5
            //5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] lines = File.ReadAllLines("dictionary_english.txt");
            //var result = lines.Sum(word => word.Length);
            //Console.WriteLine(result);
            #endregion
            #region Q6
            //6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] lines = File.ReadAllLines("dictionary_english.txt");
            //var result = lines.Min(x => x.Length);
            //Console.WriteLine(result);
            #endregion
            #region Q7
            //7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] lines = File.ReadAllLines("dictionary_english.txt");
            //var result = lines.Max(x => x.Length);
            //Console.WriteLine(result);
            #endregion

            #region Q8
            //8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] lines = File.ReadAllLines("dictionary_english.txt");
            //var result = lines.Average(word => word.Length);
            //Console.WriteLine(result);            
            #endregion

            #region Q9
            //9. Get the total units in stock for each product category.
            //var result = ProductList
            //                        .GroupBy(product => product.Category)
            //                        .Select(group => new
            //                        {
            //                            Category = group.Key,
            //                            TotalUnitsInStock = group.Sum(p => p.UnitsInStock)
            //                        });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);    
            //}
            #endregion

            #region Q10
            //10. Get the cheapest price among each category's products
            //var result = ProductList.GroupBy(product => product.Category)
            //.Select(group => new
            // {
            //     Category = group.Key,
            //     MinPriceInCategory = group.Min(product => product.UnitPrice)

            // });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q11
            //11. Get the products with the cheapest price in each category (Use Let)
            //var result = from product in ProductList
            //             group product by product.Category into g
            //             let minPrice = g.Min(p => p.UnitPrice)
            //             from p in g
            //             where p.UnitPrice == minPrice
            //             select new
            //             {
            //                 Category = g.Key,
            //                 ProductName = p.ProductName,
            //                 UnitPrice = p.UnitPrice
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q12
            //12. Get the most expensive price among each category's products.
            //var result = ProductList.GroupBy(product => product.Category)
            //                         .Select(group => new
            //                         {
            //                             Category = group.Key,
            //                             MaxPriceInCategory = group.Max(product => product.UnitPrice)

            //                         });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q13
            //13. Get the products with the most expensive price in each category.
            //var result = from product in ProductList
            //             group product by product.Category into g
            //             let maxPrice = g.Max(p => p.UnitPrice)
            //             from p in g
            //             where p.UnitPrice == maxPrice
            //             select new
            //             {
            //                 Category = g.Key,
            //                 ProductName = p.ProductName,
            //                 UnitPrice = p.UnitPrice
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q14
            //14. Get the average price of each category's products.
            //var result = ProductList.GroupBy(product => product.Category)
            //                         .Select(group => new
            //                         {
            //                             Category = group.Key,
            //                             AvgPriceInCategory = group.Average(product => product.UnitPrice)

            //                         });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region LINQ - Set Operators
            #region Q1
            //1.Find the unique Category names from Product List

            //var result = ProductList.Select(product => product.Category)
            //                         .Distinct();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q2
            //2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var result = (from Customer in CustomerList
            //              select Customer.CustomerName.Substring(0, 1))
            //             .Union(from product in ProductList
            //                    select product.ProductName.Substring(0, 1));


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q3
            //3. Create one sequence that contains the common first letter from both product and customer names.
            //var result = (from Customer in CustomerList
            //              select Customer.CustomerName.Substring(0, 1))
            //            .Intersect(from product in ProductList
            //                       select product.ProductName.Substring(0, 1));


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q4
            //4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var result = (from product in ProductList
            //              select product.ProductName.Substring(0, 1))
            //           .Except(from Customer in CustomerList
            //                   select Customer.CustomerName.Substring(0, 1));


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region LINQ - Element Operators
            #region Q1
            // 1. Get first Product out of Stock 
            //var result = ProductList.FirstOrDefault(Product => Product.UnitsInStock == 0);
            //Console.WriteLine(result);
            #endregion

            #region Q2
            //2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result = ProductList.FirstOrDefault(Product => Product.UnitPrice > 1000);
            //Console.WriteLine(result);
            #endregion
            #endregion

            #region LINQ - Partitioning Operators
            #region Q1
            //1. Get the first 3 orders from customers in Washington

            //var result = CustomerList.Where(Customer => Customer.Country == "Washington")
            //                         .SelectMany(Customer => Customer.Orders)
            //                         .Take(3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q2

            //2.Get all but the first 2 orders from customers in Washington.
            //var result = CustomerList.Where(Customer => Customer.Country == "Washington")
            //                         .SelectMany(Customer => Customer.Orders)
            //                         .Skip(2);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Q3
            //3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((num, index) => num > index);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q4
            //4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile(num => num % 3 != 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region LINQ - Quantifiers
            #region Q1
            //1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var result = words.Any(word => word.Contains("ei"));
            //Console.WriteLine(result);

            #endregion

            #region Q2
            //2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var result = ProductList.GroupBy(Product => Product.Category)
            //                        .Where(group => group.Any(product => product.UnitsInStock == 0))
            //                        .Select(group => new
            //                        {
            //                            categorie = group.Key,
            //                            Products = group.ToList()
            //                        });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.categorie);
            //    foreach (var product in item.Products)
            //    {
            //        Console.WriteLine(product);
            //    }
            //}

            #endregion

            #region Q3
            //3. Return a grouped a list of products only for categories that have all of their products in stock.
            //var result = ProductList.GroupBy(Product => Product.Category)
            //                       .Where(group => group.All(product => product.UnitsInStock > 0))
            //                       .Select(group => new
            //                       {
            //                           categorie = group.Key,
            //                           Products = group.ToList()
            //                       });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.categorie);
            //    foreach (var product in item.Products)
            //    {
            //        Console.WriteLine(product);
            //    }
            //}
            #endregion
            #endregion

            #region LINQ – Grouping Operators
            #region Q1
            //1.Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var result = numbers.GroupBy(num => num % 5)
            //                    .Select(group => new 
            //                    {
            //                        Key = group.Key,
            //                        Values = group.ToList()
            //                    });

            
            //foreach ( var item in result )
            //{
            //    Console.WriteLine($"Numbers with a remainder of {item.Key}");
            //    foreach (var value in item.Values) Console.WriteLine(value);
            //}

            #endregion

            #region Q2
            //2. Uses group by to partition a list of words by their first letter.Use dictionary_english.txt for Input
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.GroupBy(word => word.Substring(0, 1).ToUpper());
                                

            //foreach (var word in result)
            //{
            //    Console.WriteLine(word.Key);
            //}
            #endregion

            #region Q3
            //3.Consider this Array as an Input
            //Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            //string[] Arr = { "from", "salt", "earn", " last", "near", "form" };
            //var result = Arr
            //.GroupBy(word => string.Concat(word.Trim().OrderBy(c => c)));

            //foreach (var word in result)
            //{
            //    foreach (var item in word) 
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion


        }
    }
}
