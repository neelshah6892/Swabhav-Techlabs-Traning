using System;
using System.Collections.Generic;

namespace DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "One");
            dictionary.Add(2, "Two");
            dictionary.Add(3, "Three");
            dictionary.Add(4, "Four");
            dictionary.Add(5, "Five");

            foreach(KeyValuePair<int, string> dict in dictionary)
            {
                Console.WriteLine(dict);
            }

            dictionary.Remove(2);
            Console.WriteLine("");
            foreach (KeyValuePair<int, string> dict in dictionary)
            {
                Console.WriteLine(dict);
            }


            dictionary[2] = "2";
            Console.WriteLine("");
            foreach (KeyValuePair<int, string> dict in dictionary)
            {
                Console.WriteLine(dict);
            }
        }
    }
}
