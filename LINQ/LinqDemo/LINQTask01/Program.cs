using Demo01.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;
using System.Threading;
using static Demo01.ListGenerator;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LINQTask01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 Transformation
            ////1.Return a sequence of just the names of a list of products.

            //var result = ProductList.Select(Product => new { Product.ProductName });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q2 Transformation
            //2.Produce a sequence of the uppercase and lowercase versions of each word in the original array
            // (Anonymous Types).
            //  String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry"};
            //var result = words.Select(x => new
            //{
            //    Upper = x.ToUpper(),
            //    Lower = x.ToLower()
            //});


            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Upper: {item.Upper}, Lower: {item.Lower}");
            //}
            #endregion

            #region Q3 Transformation
            //3.Returns all pairs of numbers from both arrays such that the number from numbersA is less
            //  than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var result = from numA in numbersA
            //             from numB in numbersB
            //             where numA < numB
            //             select new { numA,numB};

            //foreach (var item in result)
            //{

            //    Console.WriteLine($"{item.numA} is less than {item.numB}");
            //}

            #endregion

            #region Q4 Transformation
            //4.Select all orders where the order total is less than 500.00.
            //var result = from product in ProductList
            //             where product.UnitPrice < 500
            //             select product;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q5 Transformation
            //5.Determine if the value of int in an array match their position in the array.
            //5: False
            //4: False
            //1: False
            //3: True . . . . . . . . . . . .
            //    int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where((num, index) => num == index);
            //foreach (var item in Arr)
            //{
            //    if (result.Contains(item))
            //        Console.WriteLine($"{item} : True");
            //    else
            //        Console.WriteLine($"{item} : False");
            //}
            #endregion

            #region Q1 Restriction
            //1.Find all products that are out of stock.
            //var result = ProductList.Where(Product => Product.UnitsInStock == 0);
            //foreach (var item in result)
            //{
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion

            #region Q2 Restriction
            //2.Find all products that are in stock and cost more than 3.00 per unit.
            //var result = ProductList.Where(Product => Product.UnitsInStock != 0 && Product.UnitPrice > 3);
            //foreach (var item in result)
            //{
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion

            #region Q3 Restriction
            //3.Returns Numbers whose Position is Match their value 
            //int[] Arr = { 3, 4, 2, 0, 1, 5, 6 };
            //var result = Arr.Where((num, index) => num == index);
            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Q4 Restriction
            //4.Produce a sequence containing some properties of Products, including UnitPrice which is
            //  renamed to Price in the result
            //var result = ProductList.Select(Product => new { Price = Product.UnitPrice });
            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Q5 Restriction

            #endregion

            #region Q1 LINQ - Ordering Operators
            //1.Sort a list of products by name
            //var result = ProductList.OrderBy(Product => Product.ProductName);
            //foreach (var product in result)
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            #endregion

            #region Q2 LINQ - Ordering Operators
            //2.Sort a list of products by units in stock from highest to lowest.
            //var result = ProductList.OrderByDescending(Product =>Product.UnitsInStock);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q3 LINQ - Ordering Operators
            //3.Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.OrderBy(Num=>Num.Length).ThenBy(Num=>Num);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);    
            //}

            #endregion

            #region Q4 LINQ - Ordering Operators
            //4.Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var result = ProductList.OrderByDescending(Proudct => Proudct.Category).ThenByDescending(Proudct => Proudct.UnitPrice);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q5 LINQ - Ordering Operators
            //5.Sort first by-word length and then by a case -insensitive descending sort of the words in an
            // array.
            //  string [] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(Word => Word.Length).ThenByDescending(Word => Word.ToLower());
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q6 LINQ - Ordering Operators
            //6.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in
            //the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr
            //    .Where(word => word.Length > 1 && word[1] == 'i')  
            //    .Reverse()                                         
            //    .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion



        }
    }
}
