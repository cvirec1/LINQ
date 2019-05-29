using LINQ.Data;
using LINQ.Models;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public static class Projection
    {

        /// <summary>
        /// Returns sequence of ints one higher than those in an existing array of ints.
        /// </summary>
        /// <returns>Collection with ints one higher.</returns>
        public static IEnumerable<int> Select01()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var query = numbers.Select(n=>n+1);
            // !!! INSERT YOUR LINQ  MAGIC HERE !!!

            return query;
            //return new int[] { };
        }

        /// <summary>
        /// Returns sequence of just the names of a list of products.
        /// </summary>
        /// <returns>Collection with just the names of a list of products.</returns>
        public static IEnumerable<string> Select02()
        {
            List<Product> products = DataLoader.GetProductList();
            var query = products.Select(p => p.ProductName);
            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            return query;
            //return new string[] { };
        }

        /// <summary>
        /// Returns sequence of strings representing the text version of a sequence of ints.
        /// </summary>
        /// <returns>Collection with strings representing the text version of a sequence of ints.</returns>
        public static IEnumerable<string> SelectTransformation()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var query = numbers.Select(n => strings[n]);
            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            return query;
            //return new string[] { };
        }

        /// <summary>
        /// Returns sequence of the uppercase and lowercase versions of each word in the original array.
        /// </summary>
        /// <returns>Output for each item in following format: "Uppercase: {item.upper}, Lowercase: {item.lower}"</returns>
        public static IEnumerable<string> SelectAnonymousTypes01()
        {
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            var anonymousItems = from w in words
                                 select new { Upper = w.ToUpper(), Lower = w.ToLower() };
            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            // Create LINQ query and replace anonymousItems array with its results
            // Results should be anonymous types with properties: string Upper, string Lower
            //dynamic[] anonymousItems = { new { Upper = string.Empty, Lower = string.Empty } };
            foreach (dynamic item in anonymousItems)
            {
                yield return $"Uppercase: {item.Upper}, Lowercase: {item.Lower}";
            }
        }

        /// <summary>
        /// Returns sequence containing text representations of digits and whether they are even or odd.
        /// </summary>
        /// <returns>Output for each item in following format: "The digit {item.Digit} is {item.EvenOdd}."</returns>
        public static IEnumerable<string> SelectAnonymousTypes02()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var anonymousItems = from n in numbers
                                 select new { Digit=strings[n],Even=(n%2==0)};

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            // Create LINQ query and replace anonymousItems array with its results
            // Results should be anonymous types with properties: string Digit, bool Even
            //dynamic[] anonymousItems = { new { Digit = string.Empty, Even = false } };
            foreach (dynamic item in anonymousItems)
            {
                yield return $"The digit {item.Digit} is {(item.Even ? "even" : "odd")}.";
            }
        }

        /// <summary>
        /// Returns sequence containing information about whether the values of ints in an array match their position in the array.
        /// </summary>
        /// <returns>Output for each item in following format: "{item.Digit}: {item.InPlace}."</returns>
        public static IEnumerable<string> SelectIndexed()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var anonymousItems = numbers.Select((n,index)=>new { Digit=n,InPlace = (n==index)});
            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            // Create LINQ query and replace anonymousItems array with its results
            // Results should be anonymous types with properties: int Digit, bool InPlace
            //dynamic[] anonymousItems = { new { Digit = -1, InPlace = false } };
            foreach (dynamic item in anonymousItems)
            {
                yield return $"{item.Digit}: {item.InPlace}";
            }
        }

        /// <summary>
        /// Returns sequence of the text form of each digit from an array less than 5.
        /// </summary>
        /// <returns>Collection with the text form of each digit from an array less than 5.</returns>
        public static IEnumerable<string> SelectFiltered()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var query = numbers.Where(n => n < 5).Select(n => digits[n]);
            return query;
            // !!! INSERT YOUR LINQ  MAGIC HERE !!!

            return new string[] { };
        }

        /// <summary>
        /// Returns sequence containing customers from Washington (WA) region and IDs of their orders placed on or after 1.1.1997.
        /// </summary>
        /// <returns>Collection with customers from Washington (WA) region and IDs of their orders placed on or after 1.1.1997.</returns>
        public static IEnumerable<CustomerOrderDto> SelectMany()
        {
            List<Customer> customers = DataLoader.GetCustomerList();

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!            

            return new CustomerOrderDto[] { };
        }
    }
}