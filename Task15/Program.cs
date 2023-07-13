using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //     Даны два числа.Найти их сумму, разность, произведение, 
            //     а также частное от деления первого числа на второе.

            Console.Write("Введите первое число: ");
            double enterFirstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double enterSecondNumber = Convert.ToDouble(Console.ReadLine());

            double resultNumbersSum = enterFirstNumber + enterSecondNumber;
            Console.WriteLine("Ваша сумма чисел : " + resultNumbersSum);

            double resultNumbersDifferense = enterFirstNumber - enterSecondNumber;
            Console.WriteLine("Ваша сумма чисел : " + resultNumbersDifferense);

            double resultNumbersFactum = enterFirstNumber * enterSecondNumber;
            Console.WriteLine("Ваша сумма чисел : " + resultNumbersFactum);

            double resultNumbersNotch = enterFirstNumber / enterSecondNumber;
            Console.WriteLine("Ваша сумма чисел : " + resultNumbersNotch);
        }
    }
}
