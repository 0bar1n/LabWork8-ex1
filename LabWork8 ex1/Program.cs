using System;

namespace LabWork8_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x="); //вывод на консоль
            double x = double.Parse(Console.ReadLine()); //ввод и задание переменной вещественного типа
            double y = 0; //задание переменной вещественного типа

            if (x >= 1 && x <= 2) //проверка выполнения условия
            {
                y = Math.Pow(x, 2) * Math.Log(x); //задание переменной значения по формуле
            }
            else //другой исход
                Console.WriteLine("Условие x >= 1 и x <= 2 не выполнилось"); //вывод на консоль

            if (x < 1)//проверка выполнения условия
                y = 1; //задание переменной значения
            else //другой исход
                Console.WriteLine("Условие x < 1 не выполнилось"); //вывод на консоль


            if (x > 2) //проверка выполнения условия
            {
                y = Math.Pow(Math.E, 2 * x) * Math.Cos(5 * x); //задание переменной значения по формуле
            }
            else //другой исход
                Console.WriteLine("Условие x > 2 не выполнилось"); //вывод на консоль

            Console.WriteLine($"Результат y={y}"); //вывод на консоль
        }
    }
}
