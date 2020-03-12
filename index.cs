using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = Menu.getInstance;
            menu.menuOptions();
            Console.ReadKey();
        }
    }
}
