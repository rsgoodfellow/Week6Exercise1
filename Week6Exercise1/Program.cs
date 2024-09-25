using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week6Exercise1
{
    internal class Program
    {
        static int CountWords(string fileName) //method to count words
        {
            string content = File.ReadAllText(fileName); //sets the content of the file to a string
            //splits the content into words by certain characters
            string[] words = content.Split(new char[] { ' ', '\n', '\r', '\t', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length; //returns the number of words
        }
        static void Main(string[] args) //main method
        {
            string filePath = "thing.txt"; //sets the path to txt file as a string
            int count = CountWords(filePath); //creates and initializes count integer to the output of CountWords method with filePath input
            Console.WriteLine("There are " + count + " words in this document."); //displays the number of words in the document

            Console.Read(); //lets the user read the program.
        }
    }
}
