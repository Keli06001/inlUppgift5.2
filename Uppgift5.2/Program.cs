using System;
using System.Threading.Channels;

namespace Inlämningsuppgift5_2C_A
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hur många tal vill du skriva in?");
            int tal1=int.Parse(Console.ReadLine());
            int[] tal1Array= new int[ tal1 ];   
            Console.WriteLine("Skriv in " + tal1+" heltal");
            for(int i = 0; i < tal1Array.Length; i++)
            {
                tal1Array[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Här är talen som du skrev in");
            for(int i = 0; i < tal1Array.Length; i++)
            {
                Console.WriteLine("Tal nr "+ (i + 1) +": "+ tal1Array[i]);
            }
        }   
    }
}

