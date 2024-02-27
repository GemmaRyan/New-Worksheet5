using System.Threading.Channels;

namespace Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1 Trim Spaces
            string input = " a b d s g sg  ";
            string triminput = input.Trim();
            Console.WriteLine(triminput);

            //Q2 Character positions
            int newG = 0;
            string positionOfG = "abcdefhijkglmnopqrstuvgwxyz";
            newG = positionOfG.IndexOf('g', 11);
            Console.WriteLine(newG);

            //Q3 First and Last Characters
            string firstAndLast = "abscdefghijk";
            string first = firstAndLast.Substring(0, 1);
            string last = firstAndLast.Substring(firstAndLast.Length - 1);
            Console.WriteLine(first);
            Console.WriteLine(last);

            //Q4 String Ends nny
            string ends = "asghfdjksnny";
            bool check;
            check = ends.EndsWith("nny");
            Console.WriteLine(check);

            //Q5 String Equal
            string n = "I love Sligo";
            string fake = "I love Sligo";
            if (n == fake)
            {
                Console.WriteLine("equal");
            }
            else Console.WriteLine("no");

            //Q6 Split up the words
            string a = "ab cd ed gh ij kl";
            string[] b = new string[6];

            b = a.Split();
            Console.WriteLine($"{b[0]}\n{b[1]}\n{b[2]}\n{b[3]}\n{b[4]}\n{b[5]}");

            //Q7 Replace a&bs with t&s
            string replace = "apples and bananas";
            string newAs = replace.Replace('a','t');
            string newLetters = newAs.Replace('b', 's');
            Console.WriteLine(newLetters);


            Console.ReadKey();
        }
    }
}
