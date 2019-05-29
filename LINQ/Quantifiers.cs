using LINQ.Data;
using LINQ.Models;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public static class Quantifiers
    {
        /// <summary>
        /// Checks whether any of the words in the array contains the substring 'ei'.
        /// </summary>
        /// <returns>True, if any of the words in the array contains the substring 'ei'; otherwise false.</returns>
        public static bool? Any01()
        {
            string[] words = { "believe", "relief", "receipt", "field" };
            return words.Any(w => w.Contains("ei"));
            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            
            return null;
        }

        /// <summary>
        /// Returns list of product categories where at least one product is out of stock.
        /// </summary>
        /// <returns>Collection of product categories where at least one product is out of stock.</returns>
        public static IEnumerable<string> Any02()
        {
            List<Product> products = DataLoader.GetProductList();
            return products.Where(p => p.UnitsInStock == 0).Select(p => p.Category).Distinct();
            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            
            return new string[] { };
        }

        /// <summary>
        /// Checks whether an array contains only odd numbers.
        /// </summary>
        /// <returns>True, if array contains only odd numbers; otherwise false.</returns>
        public static bool? All01()
        {
            int[] numbers = { 1, 11, 3, 19, 41, 65, 19 };
            return numbers.All(n => n % 2 == 1);
            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            
            return null;
        }

        /// <summary>
        /// Returns list of product categories where every product is in stock.
        /// </summary>
        /// <returns>Collection of product categories where every product is in stock.</returns>
        public static IEnumerable<string> All02()
        {
            List<Product> products = DataLoader.GetProductList();
            //return products.Where(p=>p.UnitsInStock)
            // !!! INSERT YOUR LINQ  MAGIC HERE !!!            
            
            return new string[] { };
        }
    }
}