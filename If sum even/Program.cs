using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_sum_even
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            string namefirst = Console.ReadLine();
            var numfirst = int.Parse(namefirst);
            Console.Write("Введите второе число : ");
            string namesec = Console.ReadLine();
            var numsec = int.Parse(namesec);
            int sum = 0;

            for (int i = numfirst; i <= numsec; i++)
            {
                if (i % 2 == 0)
                {

                    sum += i;
                }
            }
            Console.WriteLine("Сумма четных от {0} до  {1}  : {2}", namefirst, namesec, sum);
            Console.WriteLine(sum);
            Console.ReadKey();

           
        }
    }
}
