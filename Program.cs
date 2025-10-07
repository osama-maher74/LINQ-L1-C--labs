
using System.Collections.Generic;
using System.Linq;
using L2O___D09;
using static L2O___D09.ListGenerators;

namespace LINQ_L1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--1--
            //var res = ProductList.Where(p => p.UnitsInStock == 0);
           
            //var res = ProductList.Where(p => p.UnitsInStock == 0 && p.UnitPrice >= 3);
           
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var shortDigits = Arr.Where((digit, index) => digit.Length < index);
            
            //---2---
            //var res = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);

            //var res = ProductList.FirstOrDefault(p => p.UnitPrice >= 1000);

            //int[] Ar = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var secondNumberGreaterThan5 = Ar.Where(n => n > 5).Skip(1).First();

          
            //var uniqueCategories = ProductList.Select(p => p.Category).Distinct();

            //var uniqueFirstLetters = ProductList.Select(p => p.ProductName[0]).Union(CustomerList.Select(c => c.CompanyName[0]));

            //var commonFirstLetters = ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CompanyName[0]));
            //var productOnlyFirstLetters = ProductList.Select(p => p.ProductName[0]).Except(CustomerList.Select(c => c.CompanyName[0]));
            //var lastThreeChars = ProductList.Select(p => p.ProductName.Length >= 3 ? p.ProductName.Substring(p.ProductName.Length - 3) : p.ProductName)
            //                    .Concat(CustomerList.Select(c => c.CompanyName.Length >= 3 ? c.CompanyName.Substring(c.CompanyName.Length - 3) : c.CompanyName));
       

            //int[] Arr1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var oddNumberCount = Arr1.Count(n => n % 2 == 1);

            //var customerOrderCounts = CustomerList.Select(c => new { CustomerName = c.CompanyName, OrderCount = c.Orders.Count() });

            //var categoryProductCounts = ProductList.GroupBy(p => p.Category)
            //                             .Select(g => new { Category = g.Key, ProductCount = g.Count() });

            //int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var sum = Arr2.Sum();


         
            //var categoryUnitsInStock = ProductList.GroupBy(p => p.Category)
            //                             .Select(g => new { Category = g.Key, TotalUnitsInStock = g.Sum(p => p.UnitsInStock) });

            //var cheapestProductsByCategory = ProductList.GroupBy(p => p.Category)
            //                                .Select(g => g.OrderBy(p => p.UnitPrice).First());

            //var mostExpensivePricesByCategory = ProductList.GroupBy(p => p.Category)
            //                                   .Select(g => new { Category = g.Key, MostExpensivePrice = g.Max(p => p.UnitPrice) });

            //var averagePricesByCategory = ProductList.GroupBy(p => p.Category)
            //                               .Select(g => new { Category = g.Key, AveragePrice = g.Average(p => p.UnitPrice) });

          

            //Console.WriteLine(uniqueFirstLetters);

            //foreach (var item in uniqueFirstLetters)
            //{
            //    Console.WriteLine(item);

            //}

           

                //var result = ProductList.Where(p => p.UnitsInStock == 0);
                //foreach (var item in result)
                //{
                //    Console.WriteLine(item);
                //}
                //var result = ProductList.Where(p => p.UnitsInStock != 0 && p.UnitPrice > 3);
                //foreach (var item in result)
                //{
                //    Console.WriteLine(item);
                //}
            
                //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
                //var result = Arr.Select((name, index) => new { Name = name, Value = index })
                //                .Where(a=>a.Name.Length<a.Value)
                //                .Select(a=>a.Name);
                //foreach(var item in result)
                //{
                //    Console.WriteLine(item);
                //}

                   //var result = ProductList.First(p => p.UnitsInStock == 0); //if doesnot exist (Exeption).
                //var result = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);//No Exeption 
                //Console.WriteLine(result);
             
            
            //var result = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
                //Console.WriteLine(result);
              
                //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

                //var result = Arr.Where(a => a > 5).ElementAt(1);
                //Console.WriteLine(result);
               
            
            //1. Find the unique Category names from Product List
                //var result = ProductList.Select(p=>p.Category).Distinct();
                //foreach(var item in result)
                //{
                //    Console.WriteLine(item);
                //}

                //2. Produce a Sequence containing the unique first letter from both product and customer names.
                //var result = ProductList.Select(p => p.ProductName[0])
                //                         .Union(CustomerList.Select(c => c.CompanyName[0]))
                //                         .Distinct();
                //foreach (var item in result)
                //{
                //    Console.WriteLine(item);
                //}

                // 3.Create one sequence that contains the common first letter
                // from both product and customer names.
                //var result = ProductList.Select(p => p.ProductName[0])
                //                        .Intersect(CustomerList.Select(c => c.CompanyName[0]));
                //foreach (var item in result)
                //{
                //    Console.WriteLine(item); 
                //}



                //4.Create one sequence that contains the first letters of product names
                //that are not also first letters of customer names.

                //var result = ProductList.Select(p => p.ProductName[0])
                //                        .Except(CustomerList.Select(c => c.CompanyName[0]));
                //foreach (var item in result)
                //{
                //    Console.WriteLine(item);
                //}


                //5.Create one sequence that contains the last Three Characters
                //in each names of all customers and products, including any duplicates\

                //var result = ProductList.Select(p => p.ProductName.Length >= 3 ? p.ProductName[^3..] : p.ProductName)
                //                         .Concat(CustomerList.Select(c => c.CompanyName.Length >= 3 ? c.CompanyName[^3..] : c.CompanyName));
                //foreach (var item in result)
                //{
                //    Console.WriteLine(item);
                //}
                 //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                //var result  =Arr.Count(a=>a%2 !=0);
                //Console.WriteLine(result);
               
                //var result = CustomerList.Select(c => new
                //{
                //    CustomerName = c.CompanyName,
                //    OrderCount = c.Orders.Count()
                //});

                //foreach (var item in result)
                //{
                //    Console.WriteLine($"{item.CustomerName} ::: {item.OrderCount}");
                //}

               
                //var result = ProductList.Select(p => new
                //{
                //    CategoryName = p.Category,
                //    CountOfProduct = p.ProductName.Count()
                //});
                //foreach (var item in result)
                //{
                //    Console.WriteLine($"{item.CategoryName} ::: {item.CountOfProduct}");
                //}

                //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                //var result = Arr.Count();
                //Console.WriteLine(result);

               
                //(Read dictionary_english.txt into Array of String First).
                //string filePath = "dictionary_english.txt";
                //string [] content = File.ReadAllLines(filePath);
                //var result = content.Sum(c => c.Length);
                //Console.WriteLine(result);

                //var result = ProductList.Where(p=>p.UnitsInStock >0).GroupBy(p => p.Category).Select(g => new
                //{
                //    Category = g.Key,
                //    TotalUnit = g.Sum(p=>p.UnitsInStock)
                //});
                //foreach (var item in result)
                //{
                //    Console.WriteLine($"{item.Category} ::: {item.TotalUnit}");
                //}

                //string filePath = "dictionary_english.txt";
                //string[] content = File.ReadAllLines(filePath);
                //var result = content.Min(x=>x.Length);
                //Console.WriteLine(result);

                  //var result = ProductList.GroupBy(p => p.Category).Select(c => new
                //{
                //    Category = c.Key,
                //    CheapestPrice = c.Min(p => p.UnitPrice)
                //});

                //foreach (var item in result)
                //{
                //    Console.WriteLine($"{item.Category} ::: {item.CheapestPrice}");
                //} 
                    //var result = from p in ProductList
                //             group p by p.Category into c
                //             let MinPrice = c.Min(u => u.UnitPrice)
                //             select new
                //             {
                //                 Category = c.Key,
                //                 Cheapest = c.Where(u => u.UnitPrice == MinPrice)

                //             };
                //foreach (var item in result) 
                //{
                //    Console.WriteLine(item.Category);
                //    foreach(var product in item.Cheapest)
                //    {
                //        Console.WriteLine($"{product.ProductName}  , {product.UnitPrice}");
                //    }
                //}
                //string filePath = "dictionary_english.txt";
                //string[] content = File.ReadAllLines(filePath);
                //var result = content.Max(c=>c.Length);
                //Console.WriteLine(result);
                 //var result = ProductList.MaxBy(p => p.UnitPrice);
              
            //var result = ProductList.GroupBy(p=>p.Category).Select(c=> new
                //{
                //    Category = c.Key,
                //    MaxPrice = c.Max(p => p.UnitPrice),
                //    Product = c.First(p=>p.UnitPrice ==c.Max(x=>x.UnitPrice))
                //});

                //foreach(var item in result) { Console.WriteLine($"{item.Category}  -  {item.Product.ProductName}  -  {item.MaxPrice}"); }
              
            //string filePath = "dictionary_english.txt";
                //string[] content = File.ReadAllLines(filePath);
                //var result = content.Average(c => c.Length);
                //Console.WriteLine(result);
               
                //var result = ProductList.GroupBy(p => p.Category).Select(c => new
                //{
                //    category = c.Key,
                //    average = c.Average(p=>p.UnitPrice)

                //});
                //foreach (var item in result) {
                //    Console.WriteLine($"{item.category}  -  {item.average}");
                //}
               
                //var result = ProductList.OrderBy(p => p.ProductName);
                //foreach (var item in result)
                //{
                //    Console.WriteLine(item);
                //} 
               
                //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

                //var result = Arr.OrderBy(a => a.ToLower());
                //foreach (var item in result)
                //{
                //    Console.WriteLine(item);
                //}

                //By use custome comparer you need to use stringcomparer.ordinalignorecase
                //var result  =  Arr.OrderBy(a=> a, StringComparer.OrdinalIgnoreCase);

                //foreach (var item in result)
                //{
                //    Console.WriteLine(item);
                //} 
              
                //var result = ProductList.OrderByDescending(p => p.UnitsInStock);
                //foreach (var item in result)
                //{
                //    Console.WriteLine(item);
                //}

                //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
                //var result = Arr.OrderBy(a => a.Length).ThenBy(a => a);
                //foreach (var item in result)
                //{
                //    Console.WriteLine(item);
                //}
               
                //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
                //var result = words.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
                //foreach (var item in result)
                //{
                //    Console.WriteLine(item);
                //}
               
                //var result = ProductList.OrderByDescending(p => p.Category).ThenByDescending(p => p.UnitPrice);
                //foreach(var item in result)
                //{
                //    Console.WriteLine(item);
                //}
               
                //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
                //var result = Arr.OrderByDescending(a => a.Length).ThenByDescending(a => a, StringComparer.OrdinalIgnoreCase).ToArray();
                ////for (int i = 0; i < result.Length; i++)
                ////{
                ////    Console.WriteLine(result[i]);
                ////}
                //foreach(var item in result)
                //{
                //    Console.WriteLine(item);
                //}

             
                //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
                //var result = Arr.Where(a => a[1] == 'i').ToArray().Reverse();
                //foreach (var item in result) { Console.WriteLine(item); }
               
                //var result = CustomerList.Where(c => c.Address == "Washington").
                //    SelectMany(c => c.Orders).Take(3);
                //var result = CustomerList.Select(c => c.Address== "Washington").Distinct();
                //foreach (var item in result)
                //{
                //    Console.WriteLine(item);
                //}

                //var result = CustomerList.Where(c => c.Address == "Washington").
                //   SelectMany(c => c.Orders).Skip(2);
                //foreach (var item in result)
                //{
                //    Console.WriteLine(item);
                //}

                 //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                //var result = numbers.TakeWhile((n, Index) => n >= Index);
                //foreach (var item in result) { Console.WriteLine(item); }
         
                //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                //var result = numbers.SkipWhile(n => n % 3 != 0);
                //foreach(int item in result) { Console.WriteLine(item); }
               
                //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                //var result = numbers.SkipWhile((n, index) => n >= index);
                //foreach (var item in result) { Console.WriteLine(item); }
         

               
                //var result = ProductList.Select(p => p.ProductName);
                //foreach (var item in result) { Console.WriteLine(item); }

                //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
                //var result = words.Select(w => new
                //{
                //    UpperCase = w.ToUpper(),
                //    LowerCase = w.ToLower()
                //});
                //foreach(var item in result) { Console.WriteLine(item); }
                
                //var result = ProductList.Select(p => new
                //{
                //    ProductID = p.ProductID,
                //    ProductName = p.ProductName,
                //    Price = p.UnitPrice
                //});
                //foreach (var item in result)
                //{
                //    Console.WriteLine(item);
                //}
               
                //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                //var result = Arr.Select((num, index) => new

                //{
                //    num,
                //    InPosition = num == index
                //});
                //foreach (var item in result) { Console.WriteLine(item); }
              
                //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
                //int[] numbersB = { 1, 3, 5, 7, 8 };
                //var result = from a in numbersA
                //             from b in numbersB
                //             where a < b
                //             select new { a, b };

                //Console.WriteLine("Pairs where a <b");
                //foreach(var item in result)
                //{
                //    Console.WriteLine($"{item.a} is less than {item.b}");
                //}

                //var result = CustomerList.SelectMany(c => c.Orders).Where(o => o.Total < 500);
                //foreach (var item in result) { Console.WriteLine(item); }
            
                //var result = CustomerList.SelectMany(c => c.Orders).Where(o => o.OrderDate.Year >= 1998);
                //foreach(var item in result)
                //{
                //    Console.WriteLine(item);
                //}
                

                //string filePath = "dictionary_english.txt";
                //string[] content = File.ReadAllLines(filePath);

                //var result = content.Any(c => c.Contains("ei",StringComparison.OrdinalIgnoreCase));
                //Console.WriteLine(result);


      
                //var result = ProductList.GroupBy(p => p.Category).Where(c => c.Any(p => p.UnitsInStock == 0)).Select(x => new
                //{
                //    category = x.Key,
                //    product = x.ToList()
                //});
                //foreach(var item in result)
                //{
                //    Console.WriteLine($"Category  :::  {item.category}");
                //    foreach (var product in item.product)
                //    {
                //        Console.WriteLine($"Product  :::  {product.ProductName} ");
                //    }
                //    Console.WriteLine("=================================================");
                //}
               
                //var result = ProductList.GroupBy(p => p.Category).Where(c => c.All(p => p.UnitsInStock != 0)).Select(x => new
                //{
                //    category = x.Key,
                //    product = x.ToList()
                //});
                //foreach (var item in result)
                //{
                //    Console.WriteLine($"Category  :::  {item.category}");
                //    foreach (var product in item.product)
                //    {
                //        Console.WriteLine($"Product  :::  {product.ProductName} ");
                //    }
                //    Console.WriteLine("=================================================");
                //}
               
                //int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 , 15 };

                //var result = numbers.GroupBy(n => n % 5);

                //foreach (var group in result)
                //{
                //    Console.WriteLine($"Numbers with a remainder of {group.Key} when divided by 5:");
                //    foreach (var num in group)
                //    {
                //        Console.WriteLine(num);
                //    }
                //}
          
                //string filePath = "dictionary_english.txt";
                //string[] content = File.ReadAllLines(filePath);

                //var result = content
                //    .GroupBy(c => char.ToUpper(c[0]));


                //foreach (var item in result)
                //{
                //    Console.WriteLine($"Words starting with '{item.Key}':");
                //    foreach (var word in item)
                //    {
                //        Console.WriteLine(word);
                //    }
                //}
          
                //,Use Group By with a custom comparer that matches words that are consists of the same Characters Together
                // string[] Arr = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };
                // var result = Arr
                //.Select(w => w.Trim()) 
                //.GroupBy(word => string.Concat(word.OrderBy(c => c))) 
                //.ToList();

                // foreach (var item in result)
                // {
                //     Console.WriteLine("....");
                //     foreach (var word in item)
                //     {
                //         Console.WriteLine(word);
                //     }
                // }

               


        }






        }
   
}
