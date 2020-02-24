using System;
using System.Collections.Generic;
using System.Linq;


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

            string temp_string;
            while (key != 48)
            {
                Console.WriteLine("\n\nВведите " + (amount_of_elements + 1) + "-ю строку: ");
                temp_string = Console.ReadLine();
                if (temp_string != null && temp_string.Length == 0) continue;
                array_of_string[amount_of_elements] = temp_string;
                amount_of_elements++;
                Console.WriteLine("\nХотите продолжить вводить новые строки? (1 - да, 0 - нет)");
                key = (int) Console.ReadKey().KeyChar;
            }
        }

        static void check()    // функция на вывод элемента массива или всего массива
        {
            int key = 0;
            while (true)
            {
                Console.WriteLine("\n\nВведите какой элемент хотите просмотреть(или -1 если хотите выйти): ");
                try
                {
                    key = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                if (key == -1) return;
                else if (key == 0)
                {
                    Console.WriteLine("\nВывожу все строки:\n");
                    for (int i = 0; i < amount_of_elements; i++)
                        Console.WriteLine((i + 1) + ") " + array_of_string[i]);
                }
                else if (key <= amount_of_elements) Console.WriteLine("\nВаша строка - " + array_of_string[key - 1]);
                else Console.WriteLine("\nВы ввели неверное значение индекса. Попробуйте ещё.");
            }
        }
        
        static void task1()    // функция на первую задачу
        {
            int first_index = 0, second_index = 0;
            do
            {
                Console.WriteLine("\n\nВведите ИНДЕКС первой строки: ");
                try
                {
                    first_index = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    first_index = -1;
                }
            } while (first_index > amount_of_elements || first_index < 0);

            do
            {
                Console.WriteLine("\n\nВведите ИНДЕКС второй строки: ");
                try
                {
                    second_index = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    second_index = -1;
                }
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
            
            Console.WriteLine("\nНовая строка - " + task_string);
        }
        
        static void task2()    // функция на первую задачу
        {
            int first_index = 0, second_index = 0;
            do
            {
                Console.WriteLine("\n\nВведите ИНДЕКС первой строки: ");
                try
                {
                    first_index = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    first_index = -1;
                }
            } while (first_index > amount_of_elements || first_index < 0);

            do
            {
                Console.WriteLine("\n\nВведите ИНДЕКС второй строки: ");
                try
                {
                    second_index = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    second_index = -1;
                }
            } while (second_index > amount_of_elements || second_index < 0);
            
            char[] test_array = array_of_string[first_index].ToCharArray();
            char[] test_array1 = array_of_string[second_index].ToCharArray();
            
            var ls = new List<char>();
            ls.AddRange(test_array);
            ls.AddRange(test_array1);
            var uniques = ls.Distinct();
            Console.WriteLine("\nНовая строка: ");
            foreach (var VARIABLE in uniques)
                Console.Write(VARIABLE);
        }
        
        static void menu()    // меню
        {
            while (true)
            {
                Console.WriteLine("\n\nМеню управления программой:\n" +
                                  "1 - работа с массивом (добавление строки);\n" +
                                  "2 - просмотр выбранного элемента;\n" +
                                  "3 - задача поэлементного сцепления двух строк;\n" +
                                  "4 - задача на сложение двух двух строк с исключением дубликатов;\n" +
                                  "ESC - выход;\n" +
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
                    case 52:
                        task2();
                        break;
                    case 27:
                        return;
                }   
            }
        }
    }
}