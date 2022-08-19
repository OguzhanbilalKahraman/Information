using System;

namespace _01.Delege
{
    delegate void benimDelegem(int sayi1, int sayi2);
    class Program
    {
        static void Main(string[] args)
        {
            benimDelegem BenimDelegem = new benimDelegem(Topla);
            BenimDelegem += Carp;
            BenimDelegem.Invoke(1,2);
            Console.WriteLine("Hello World!");
        }
        static void Topla(int numara1, int numara2)
        {
            Console.WriteLine(numara1+numara2);
        }

        static void Carp(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1*sayi2);
        }
    }

    
}
