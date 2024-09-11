using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выполнение операции над числами");
            Console.Write("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сумма чисел равна " + (a + b));
            Console.WriteLine("Разность чисел равна " + (a - b));
            Console.WriteLine("Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
