using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebuster
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bytebuster [1.0]");
             
            string binært = "";
            Random value = new Random();
            int tal = 0; int rigtig = 0; int forkert = 0; int gæt = 0;

            do
            {
                tal = value.Next(0, 255);
                binært = Convert.ToString(tal, 2);
                Console.WriteLine(binært); Console.WriteLine("gæt dette binære tal");
                
                gæt = Convert.ToInt32(Console.ReadLine());
                if (gæt == tal)
                {
                    Console.WriteLine("Korrekt!");
                    rigtig++;
                    Console.WriteLine(rigtig);
                    Console.Write("Du har "); Console.Write(rigtig); Console.WriteLine(" rigtig");
                }
                else
                {
                    Console.WriteLine("Forkert!");
                    forkert++;
                    Console.Write("Du har "); Console.Write(forkert); Console.WriteLine(" forkert");
                }
                

            } while (rigtig < 3 & forkert < 3);
            Console.WriteLine("Slut");
            Console.ReadLine();



        }
    }
}
