using System;

namespace _03.ActionDelegeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Action action = new Action(SelamVer);
            action.Invoke();
            Action<string, int> action2 = new Action<string, int>(SelamVer2);
            action2.Invoke("Oguz",22);
            Console.WriteLine("Hello World!");
        }

        private static void SelamVer2(string arg1, int arg2)
        {
            Console.WriteLine("Selam "+arg1+" "+arg2 );
        }

        private static void SelamVer()
        {
            Console.WriteLine("Selam Oguz");
        }
    }
}
