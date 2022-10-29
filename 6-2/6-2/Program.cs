using System;
namespace t62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(1, "one");
            dictionary.Add(2, "two");
            Console.WriteLine($"Count of pairs: {dictionary.Count}");
            foreach (KeyValuePair<int, string> ele in dictionary)
            {
                Console.WriteLine($"Key = {ele.Key}, Value = {ele.Value}");
            }
        }
    }
}