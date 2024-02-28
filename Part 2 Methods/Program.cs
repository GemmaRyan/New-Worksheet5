using System.Security.Cryptography.X509Certificates;

namespace Part_2_Methods
{
    internal class Program
    {
        static List<char> abc = new List<char> {'a','b','c','d', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'} ;
        static List<char> finish = new List<char> { } ;
        static void Main(string[] args)
        {
            string test = "hello";

            Console.WriteLine( CountCharInString("dkfjda;lfjladsfkjl", 'a'));
            Console.WriteLine(CountCharInString("dkfjda;lfjladsfkjl", 'l'));

        }
        static int[] CountAllCharsInString (string input)
            {
            int[] counts = new int[26];

            for (int i = 0; i < abc.Count; i++)
            {

                counts[i] = CountCharInString(input, abc[i]);
            }
            return counts;
        }
        static int CountCharInString (string input, char c)
        {
            int count = 0;
            for (int i =0; i < input.Length; i++)
            {
                if (input[i] == c)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

