using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string q = Console.ReadLine();
            switch (q)
            {
                case "1":
                    Adress M = new Adress();
                    M.SetInfo();
                    Console.WriteLine("");
                    M.GetInfo();
                    break;
            }
            Console.ReadLine();
        }
    }
}
