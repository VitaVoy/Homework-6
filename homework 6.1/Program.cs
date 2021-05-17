using System; //Виталий Войтов
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6._1 // Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double)
{
    
    public delegate double Fun(double x);
    class Program
    {
        private static double a;

        public static void Table(Fun F, double x, double a)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= a)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        
        public static double MyFunc(double x, double a)
        {
            return a * x * x;
        }
        public static double Sinus(double x, double a)
        {
            return a * Math.Sin(x);
        }
        static void Main()
        {
            Console.WriteLine("Таблица функции a*x^2:");
            Table(delegate (double x) { return a * x * x; }, 0, 3);
            Console.WriteLine("Таблица функции a*sin(x):");
            Table(delegate (double x) { return a * Math.Sin(x); }, 0, 3);
            Console.ReadLine();

        }

    }
}