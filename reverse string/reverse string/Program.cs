using System;

namespace reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "kushal";
            char[] ch = s.ToCharArray();
            string rev = null;
            for ( int i=ch.Length-1; i >=0; i--)
            {
                rev = rev + ch[i];
                
            }
            Console.WriteLine(rev);
            Console.ReadKey();
        }
    }
}
