using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    internal class task17
    {
        static void Main(string[] args)
        {
            //Известны координаты на плоскости двух точек. 
            //Составить программу вычисления расстояния между ними.

            Console.Write("Введите первую координату х: ");
            int firstDote = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите вторая координату х: ");
            int secondDote = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите первую координату y: ");
            int thirdDote = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите первую координату y: ");
            int forthDote = Convert.ToInt32(Console.ReadLine());

            double interval = Math.Sqrt(Math.Pow((secondDote - firstDote), 2)
                + Math.Pow((forthDote - thirdDote), 2));
            Console.WriteLine("Расстояние между точками равно :" + interval);

            
        }
    }
}
