using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab3_1test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел в списке: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cписок силы тока: ");
            List<float> Amperage = new List<float>(n);
            for (int i = 0; i < n; i++)
            {
                Amperage.Add(float.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Список напряжения: ");
            List<float> Voltage = new List<float>(n);
            for (int i = 0; i < n; i++)
            {
                Voltage.Add(float.Parse(Console.ReadLine()));
            }

            //R = U / I (Закон Ома)
            float[] R = new float[n];
            Console.WriteLine("По закону Ома, сопротивление R равняется:");
            for (int i = 0; i < n; i++)
            {
                R[i] = Voltage[i] / Amperage[i];
                Console.WriteLine(R[i]);
            }
        }
    }
}