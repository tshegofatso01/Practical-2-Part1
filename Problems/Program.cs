using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter text");
            string txt = Console.ReadLine();

            Console.WriteLine(prefix(txt));

            Console.ReadKey();
        }
		static string prefix(string input)
        {
            if (input.Trim() == "")
            {
                return "0,0:";
            }
            else
            {
                int num_let = input.Length;     //num of alphabets in the string
                string len = num_let.ToString(); // convert it to string


                string[] words = input.Split(); //array of words
                int num_words = words.Length; //length of words
                string num_w = num_words.ToString();



                string ans = len + "," + num_w + ":" + input; // the entire string

                return ans;
            }
            

        }
    }
}
