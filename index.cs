using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = Menu.Instance;
            menu.menuOptions();
            Console.ReadKey();
        }
    }
}
