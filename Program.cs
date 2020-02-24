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
        
        static void task1()    // функция на добавление новой строки
        {
            int first_index = 0, second_index = 0;
            do
            {
                Console.WriteLine("\n\nВведите ИНДЕКС первой строки: ");
                first_index = Int32.Parse(Console.ReadLine());
            } while (first_index > amount_of_elements || first_index < 0);

            do
            {
                Console.WriteLine("\n\nВведите ИНДЕКС второй строки: ");
                second_index = Int32.Parse(Console.ReadLine());
            } while (second_index > amount_of_elements || second_index < 0);

            string task_string = new string("");

            for (int i = 0; i < array_of_string[first_index].Length; i++)
            {
                if (i != array_of_string[first_index].Length && i != array_of_string[second_index].Length)
                {
                    task_string += array_of_string[first_index][i];    // c#шарп тупой
                    task_string += array_of_string[second_index][i];   
                }
                else break;
            }
            
            Console.WriteLine(task_string);
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