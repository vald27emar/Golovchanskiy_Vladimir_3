using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3test3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = Enumerable.Range(0, 10).Select(i => i * i).ToList();

            Console.WriteLine("Последовательность чисел: ");
            foreach (int num in numbers)
                Console.WriteLine(num);

            var search = numbers.Where(i => i >= 10 && i <= 99);

            try
            {
                var count = search.Count();
                double average = search.Average();

                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine($" Количество двузначных положительных чисел: {count}");
                Console.WriteLine($" Среднее арифметическое: {average}");
                Console.WriteLine("----------------------------------------------------");
            }
            catch
            {
                double v = 0.0;
                int cv = Convert.ToInt32(v);
                Console.WriteLine(cv);
                Console.WriteLine("{0:0.0}", v);
            }
        }
    }
}