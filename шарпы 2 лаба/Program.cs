using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace шарпы_2_лаба
{
    internal class Program
{    static double taylor(double x, double epsilon)
    {
        double term = 1/2.0 * x; 
        double sum = 1 + term; 
        int n = 0; 

        while (Math.Abs(term) > epsilon)
        {
            term *= -x * ((2 * n + 1.0) / (2 * n + 4.0) );
            sum += term;
            n++;
        }

        return sum;
    }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите X0 (|X0| < 1):");
            double X0 = Convert.ToDouble(Console.ReadLine());
            //double X0 = -0.1;


            Console.WriteLine("Введите Xn (|Xn| < 1):");
            double Xn = Convert.ToDouble(Console.ReadLine());
            //double Xn = 0.1;


            Console.WriteLine("Введите шаг h:");
            double h = Convert.ToDouble(Console.ReadLine());
           // double h = 0.1;


            Console.WriteLine("Введите точность E:");
            double epsilon = Convert.ToDouble(Console.ReadLine());
            //double epsilon = 0.00001;



            Console.WriteLine("\n----------------------------------------------------");
            Console.WriteLine("|   X   |   f(X) вычисл. (Тейлор)   |   f(X) по формуле   |");
            Console.WriteLine("----------------------------------------------------");

            for (double x = X0; x <= Xn; x += h)
            {
                double taylorApprox = taylor(x, epsilon);
                double exactValue = Math.Sqrt(1 + x);

                Console.WriteLine($"| {x,5:F2} | {taylorApprox,25:F15} | {exactValue,19:F15} |");
            }

            Console.WriteLine("----------------------------------------------------");
        }
    }
}
