using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo {
    class Program {
        static void Main(string[] args) {
            string[] words = { "Hello", "How are you", "LINQ", "that", "is", "awesome" };
            var shortWords = from word in words
                             where word.Length <= 8
                             select word;
            foreach (var word in shortWords) {
                Console.WriteLine(word);
            }
            var longWords = words.Where(w => w.Length > 10);
            Console.WriteLine(longWords);
            Console.ReadLine();
        }
    }
}