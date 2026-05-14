using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint n = 0;
            int k = 0;

            string input = "";
            string output = "";

            // Task1
            
            Console.WriteLine("1:");
            Console.WriteLine("Введите натуральное число n - кол-во чисел в файле.");
            n = Input.InputUInt("n: ");
            Console.WriteLine("Введите целое число k - делитель.");
            k = Input.InputInt("k: ");

            input = "input.txt";
            output = "task_1_output.txt";

            File.MakeFile1(n, input);
            File.Task1(k, input, output);

            Console.WriteLine("\nИсходный случайно заполненный файл -> " + input);
            Console.WriteLine("Результат работы программы -> " + output);
            
            // Task2
            
            Console.WriteLine("\n2:");
            Console.WriteLine("Введите натуральное число n - кол-во строк в файле.");
            n = Input.InputUInt("n: ");
            Console.WriteLine("Введите натуральное число k - кол-во чисел в каждой строке.");
            
            input = "task_2_input.txt";

            File.MakeFile2(n, Input.InputUInt("k: "), input);
            Console.WriteLine("Сумма первого и максимального элемента: " + File.Task2(input));
            Console.WriteLine("\nИсходный случайно заполнненый файл -> " + input);
            
            // Task3
            
            Console.WriteLine("\n3:");
            input = "task_3_input.txt";
            output = "task_3_output.txt";
            File.MakeFile3(input);
            File.Task3(input, output);
            Console.WriteLine("\nИсходный случайно заполнненый файл(33x100) -> " + input);
            Console.WriteLine("Результат работы программы -> " + output);
            
            // Task4
            
            Console.WriteLine("\n4:");
            input = "task_4_input.bin";
            output = "task_4_output.bin";

            Console.WriteLine("Введите натуральное n - кол-во чисел в файле.");
            n = Input.InputUInt("n: ");
            File.MakeFile4(n, input);
            File.Task4(input, output);

            Console.WriteLine("\nИсходный случайно заполнненый файл -> " + input);
            Console.WriteLine("Результат работы программы -> " + output);
        }
    }
}
