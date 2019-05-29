using System.Collections.Generic;
using System.Linq;
namespace LINQ
{
    public static class Grouping
    {
        /// <summary>
        /// Returns dictionary with numbers grouped by their remainder when divided by 5.
        /// </summary>
        /// <returns>Dictionary where key is remainder and value is list of numbers with that remainder when divided by 5.</returns>
        public static Dictionary<int, int[]> GroupBy01()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var query = numbers.GroupBy(n => n%5).ToDictionary(n => n.Key, n => n.ToArray());
            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            // Use ToDictionary(x => {key}, x => {values})
            // Use group.Key as Dictionary key and group as Dictionary values
            // If compiler complains about IGrouping<int, int>, use ToArray() method
            return query;
            return new Dictionary<int, int[]>();
        }

        /// <summary>
        /// Returns dictionary with words grouped by their first letter.
        /// </summary>
        /// <returns>Dictionary where key is first letter of the word and value is word itself.</returns>
        public static Dictionary<char, string[]> GroupBy02()
        {
            string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };
            return  words.GroupBy(w => w[0]).ToDictionary(w => w.Key, w => w.ToArray());
            // !!! INSERT YOUR LINQ  MAGIC HERE !!!
            // Use ToDictionary(x => {key}, x => {values})
            // Use group.Key as Dictionary key and group as Dictionary values
            // If compiler complains about IGrouping<char, string>, use ToArray() method
            
            return new Dictionary<char, string[]>();
        }
    }
}