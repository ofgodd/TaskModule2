using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task24
{
    internal class task24
    {
        static void Main(string[] args)
        {
            //    Возраст Тани — X лет, а возраст Мити — Y лет. Найти их средний возраст,
            //    а также определить, на сколько отличается возраст каждого ребенка от среднего значения. 

            Random rnd = new Random();
            int oldTania = rnd.Next(1, 17);
            Console.WriteLine("Возраст Тани: " + oldTania);

            int oldMitia = rnd.Next(1, 17);
            Console.WriteLine("Возраст Тани: " + oldMitia);

            double midleOldChildren = (oldTania + oldMitia) / 2;
            Console.WriteLine("Средний возраст: " + midleOldChildren);

            double distinctionOldMidleTania = midleOldChildren - oldTania;
            Console.WriteLine($"На  {distinctionOldMidleTania} отличается " +
                $"возраст от среднего значения Тани");

            double distinctionOldMidleMitia = midleOldChildren - oldMitia;
            Console.WriteLine($"На  {distinctionOldMidleMitia} отличается " +
                $"возраст от среднего значения Мити");


        }
    }
}
