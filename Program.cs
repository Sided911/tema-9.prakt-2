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
            //Задача 1. Заполнить одномерный массив с клавиатуры
            //шестью целыми числами. Вывести одномерный массив в обратном порядке.
            Console.Write("Введите чсило элемента ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++) //в последовательном порядке
            {
                Console.Write($"array[{i}]=");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = array.Length - 1; i >= 0; i--) //в обратном порядке
            {
                Console.Write($"array[{i}]=");
                array[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
