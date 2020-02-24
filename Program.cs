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

        static void write()    // функция на добавление новой строки
        {
            int key = 0;
            if (amount_of_elements == len_of_array)    // если массив заполнен (контроль длины массива)
            {
                Console.WriteLine("\n\n Массив строк забит, вы не можете больше в него что-либо писать,\n" +
                                  "для продолжения нажмите любую кнопку.");
                Console.ReadKey();
                return;
            }
            while (key != 48)
            {
                Console.WriteLine("\n\nВведите " + (amount_of_elements + 1) + "-ю строку: ");
                array_of_string[amount_of_elements] = Console.ReadLine();
                amount_of_elements++;
                Console.WriteLine("\nХотите продолжить вводить новые строки? (1 - да, 0 - нет)");
                key = (int) Console.ReadKey().KeyChar;
            }
        }

        static void check()    // функция на добавление новой строки
        {
            int key = 0;
            while (true)
            {
                Console.WriteLine("\n\nВведите какой элемент хотите просмотреть(или 0 если хотите выйти): ");
                key = Int32.Parse(Console.ReadLine());
                if (key == 0) return;
                if (key <= amount_of_elements) Console.WriteLine("\nВаша строка - " + array_of_string[key - 1]);
                else Console.WriteLine("\nВы ввели неверное значение индекса. Попробуйте ещё.");
            }
        }
        
        
        static void menu()    // меню
        {
            while (true)
            {
                Console.WriteLine("Меню управления программой:\n" +
                                  "1 - работа с массивом (добавление строки);\n" +
                                  "2 - просмотр выбранного элемента;\n" +
                                  "3 - задача поэлементного сцепления двух строк;\n" +
                                  "Ваш выбор: ");
                switch ((int)Console.ReadKey().KeyChar)        // считываем что ввел пользователь
                {
                    case 49:
                        write();
                        break;
                    case 50:
                        check();
                        break;
                    case 51:
                        task1();
                        break;
                    case 27:
                        return;
                }   
            }
        }
    }
}