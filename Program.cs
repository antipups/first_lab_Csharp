using System;
using System.Text;

namespace first_lab_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        static void menu()    // меню
        {
            while (true)
            {
                switch ((int)Console.ReadKey().KeyChar)        // считываем что ввел пользователь
                {
                    case 49:
                        Console.WriteLine("sex");
                        break;
                    case 50:
                        Console.WriteLine("sex");
                        break;
                    case 51:
                        Console.WriteLine("sex");
                        break;
                    case 27:
                        return;
                }   
            }
        }
    }
}
