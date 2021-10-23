using System;
using System.Linq;

namespace Obj_Tools
{
    class Program
    {
        // Most simple password gen
        static void Main(string[] args)
        {
            Console.WriteLine("LOG: What Length Should Your Password be?");
            var inp = Console.ReadLine();
            var input = Convert.ToInt32(inp);
            Console.WriteLine(RandomString(input));
            Console.ReadLine();
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789#$äÖ?12345678910!§%&/()=";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
