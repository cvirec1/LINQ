﻿using LINQ.Data;
using LINQ.Models;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public static class Ordering
    {

        /// <summary>
        /// Returns collection of words sorted alphabetically.
        /// </summary>
        /// <returns>Collection of words sorted alphabetically.</returns>
        public static IEnumerable<string> OrderBy01()
        {
            string[] words = { "cherry", "apple", "blueberry" };
            var query = words.OrderBy(w => w);
            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            return query;
            return new string[] { };
        }

        /// <summary>
        /// Returns collection of words sorted by their length.
        /// </summary>
        /// <returns>Collection of words sorted by their length.</returns>
        public static IEnumerable<string> OrderBy02()
        {
            string[] words = { "cherry", "apple", "blueberry" };
            var query = words.OrderBy(w => w.Length);
            // !!! INSERT YOUR LINQ  MAGIC HERE !!!            
            return query;
            return new string[] { };
        }

        /// <summary>
        /// Returns collection of products sorted by name.
        /// </summary>
        /// <returns>Collection of products sorted by name.</returns>
        public static IEnumerable<Product> OrderBy03()
        {
            List<Product> products = DataLoader.GetProductList();
            var query = products.OrderBy(p => p.ProductName);
            // !!! INSERT YOUR LINQ  MAGIC HERE !!!            
            return query;
            return new Product[] { };
        }

        /// <summary>
        /// Returns collection of doubles sorted from highest to lowest.
        /// </summary>
        /// <returns>Collection of doubles sorted from highest to lowest.</returns>
        public static IEnumerable<double> OrderByDescending01()
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };
            var query = doubles.OrderByDescending(d => d);
            // !!! INSERT YOUR LINQ  MAGIC HERE !!!            
            return query;
            return new double[] { };
        }

        /// <summary>
        /// Returns collection of products sorted by units in stock from highest to lowest.
        /// </summary>
        /// <returns>Collection of products sorted by units in stock from highest to lowest.</returns>
        public static IEnumerable<Product> OrderByDescending02()
        {
            List<Product> products = DataLoader.GetProductList();
            var query = products.OrderByDescending(p => p.UnitsInStock);
            // !!! INSERT YOUR LINQ  MAGIC HERE !!!            
            return query;
            return new Product[] { };
        }

        /// <summary>
        /// Returns collection of digits sorted first by length of their name, and then alphabetically by the name itself.
        /// </summary>
        /// <returns>Collection of digits sorted first by length of their name, and then alphabetically by the name itself.</returns>
        public static IEnumerable<string> ThenOrderBy()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var query = digits.OrderBy(d=>d.Length).ThenBy(d=>d);
            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            return query;
            return new string[] { };
        }

        /// <summary>
        /// Returns collection of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
        /// </summary>
        /// <returns>Collection of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.</returns>
        public static IEnumerable<string> Reverse()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var query = digits.Where(d=>d[1]=='i').Reverse();
            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            return query;
            return new string[] { };
        }
    }
}