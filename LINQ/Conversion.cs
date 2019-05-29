using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public static class Conversion
    {
        /// <summary>
        /// Returns sequence ordered from highest number to lowest as an array.
        /// </summary>
        /// <returns>Array with numbers ordered in descending order.</returns>
        public static double[] ToArray()
        {
            List<double> doubles = new List<double> { 1.7, 2.3, 1.9, 4.1, 2.9 };
            var query = doubles.OrderByDescending(d => d).ToArray();
            // !!! INSERT YOUR LINQ  MAGIC HERE !!!            
            return query;
            return new double[] { };
        }

        /// <summary>
        /// Returns sequence ordered alphabetically as a list.
        /// </summary>
        /// <returns>List with words ordered alphabetically.</returns>
        public static List<string> ToList()
        {
            string[] words = { "cherry", "apple", "blueberry" };
            return words.OrderBy(w => w).ToList();
            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            
            return new List<string>();
        }

        /// <summary>
        /// Returns dictionary of test results.
        /// </summary>
        /// <returns>Dictionary with test results where student name is the key and their score is the value.</returns>
        public static Dictionary<string, int> ToDictionary()
        {
            var scoreRecords = new[] { new {Name = "Alice", Score = 50},
                                       new {Name = "Bob"  , Score = 40},
                                       new {Name = "Cathy", Score = 45} };

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            
            return new Dictionary<string, int>();
        }

        /// <summary>
        /// Returns only elements of type double from array.
        /// </summary>
        /// <returns>Collection with only elements of type double.</returns>
        public static IEnumerable<double> OfType()
        {
            object[] numbers = { null, 1.0, "two", 3, "four", 5, "six", 7.0 };

            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            
            return new double[] { };
        }
    }
}