using System;
using LIbrary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataStoreLoggingDAO ds = new DataStoreLoggingDAO();

            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\David\Desktop\Pwned\pwned-passwords-sha1-ordered-by-count-v5.txt");

            while ((line = file.ReadLine()) != null)
            {
                ds.Create(line);
            }
        }
    }
}
