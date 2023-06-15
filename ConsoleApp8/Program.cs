using System;
using System.Collections.Generic;

//Вариант 1												H[Array]
//Задача 1
//Даны N отрицательные целые числа, представляющие карту высот, где ширина каждой полосы равна 1.
//Необходимо вычислить сколько воды можно удержать после дождя.


namespace ConsoleApp8
{
    internal class Program
    {
        static public int CalcWater(List<int> depths)
        {
            int result = 0;
            int max = depths[0];
            int index = 0;
            for(int i = 1; i < depths.Count; i++)
            {
                if (depths[i] > max)
                {
                    max = depths[i];
                    index = i;
                }
            }

            int min = depths[0];
            for (int i = 1; i < index; i++)
            {
                if (depths[i] >= min)
                {
                    min = depths[i];
                }
                else
                {
                    result += min - depths[i];
                }
            }
            for (int i = depths.Count - 2; i > index; i--)
            {
                if (depths[i] >= min)
                {
                    min = depths[i];
                }
                else
                {
                    result += min - depths[i];
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine("Введите значения высот по одному, для окончания ввода введите \"end\":");
            string input = null;
            do
            {
                Console.Write("Введите следующее значение: ");
                input = Console.ReadLine();
                if(Int32.TryParse(input, out int value))
                {
                    list.Add(value);
                }
                else
                {
                    Console.WriteLine("Невозможно преобразовать в целое число. Попробуйте снова.");
                }
            } while (input != "end");
            Console.WriteLine("Вы закончили ввод значений высот, приступаем к расчету.");
            int volumeWater = CalcWater(list);
            Console.WriteLine($"Количество воды в единицах, которое может удержаться после дождя равно {volumeWater}");
        }
    }
}
