using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Даны основания и высота равнобедренной трапеции. Найти ее периметр.

            Console.Write("Введите длину меньшего основания ");
            double baseOne = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину большего основания ");
            double baseTwo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту трапеции ");
            double height = Convert.ToDouble(Console.ReadLine());

            double cathetus = (baseTwo - baseOne) / 2;
            double hypotenuse = Math.Sqrt(Math.Pow(cathetus, 2) + Math.Pow(height, 2));

            double perimeter = hypotenuse * 2 + baseOne + baseTwo;

            Console.WriteLine("Пермитер равен : " + perimeter);

        }
    }
}
