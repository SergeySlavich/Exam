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
            foreach(int depth in depths)
            {
                if(depth < 0)
                {
                    result += depth;
                }
            }
            return -result;
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine("Введите значения глубин по одному (отрицательными числами), для окончания ввода введите \"end\":");
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
            Console.WriteLine("Вы закончили ввод значений глубин, приступаем к расчету.");
            int volumeWater = CalcWater(list);
            Console.WriteLine($"Количество воды в единицах, которое может удержаться после дождя равно {volumeWater}");
        }
    }
}
