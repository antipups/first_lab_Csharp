using System;


namespace first_lab_Csharp
{
    class Program
    {
        const int len_of_array = 50;
        static string[] array_of_string = new string[len_of_array];
        static int amount_of_elements = 0;
        
        static void Main(string[] args)
        {
            menu();
        }

        static void write_and_delete()    // функция на добавление новой строки
        {
            int key = 0;
            while (key != 48)
            {
                Console.WriteLine("\n\nВведите " + (amount_of_elements + 1) + "-ю строку: ");
                array_of_string[amount_of_elements] = Console.ReadLine();
                amount_of_elements++;
                Console.WriteLine("\nХотите продолжить вводить новые строки? (1 - да, 0 - нет)");
                key = (int) Console.ReadKey().KeyChar;
            }
        }
        
        static void menu()    // меню
        {
            while (true)
            {
                Console.WriteLine("Меню управления программой:\n" +
                                  "1 - работа с массиво (добавление строки);\n" +
                                  "Ваш выбор: ");
                switch ((int)Console.ReadKey().KeyChar)        // считываем что ввел пользователь
                {
                    case 49:
                        write_and_delete();
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
