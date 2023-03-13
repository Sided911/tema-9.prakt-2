using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 2. В массиве хранятся сведения о количестве осадков, выпавших за каждый
            //день января (использовать заполнение случайным образом целыми числами в диапазоне от 5 до 60 мм).
            //Определить общее количество осадков за январь.
            int[] array = new int[31];
            Random rnd = new Random();
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(5, 60);
                Console.WriteLine($"array[{i}]={array[i]}");
            }
            int summ = 0;
            for(int i = 0; i < array.Length; i++)
            {
                summ += array[i];
            }
            Console.WriteLine($"Общее количество осадков={summ}");
            Console.ReadKey();
        }
    }
}
