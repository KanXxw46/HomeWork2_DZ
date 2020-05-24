using System;
using System.ComponentModel;
using System.Drawing;
using System.Dynamic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HomeWork2._1
{
    class Program
    {
        //Task 1
        static void Main(string[] args)
        {
            Console.WriteLine("123");
        }
        static void task1(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(a + "  " + b + "  " + c);
        }
        //Task 2
        static void def(string[] args)
        {
            double d = 5;
            double e = 10;
            double f = 21;
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
        }
        //Task 3
        static double СentimetersInMeters(double Сentimeters)
        {
            return Сentimeters / 100;
        }
        //Task 4
        static int DaysOfWeek(int Days)
        {
            return Days / 7;
        }
        //Task 5
        static void Numbers(int Digits)
        {
            Console.WriteLine("Amount of des:" + Digits/10);
            Console.WriteLine("Amount of des:" + Digits / 10);
            int SumOfDigits = 0;
            while (Digits != 0)
            {
                SumOfDigits += Digits % 20;
                SumOfDigits /= 10;
            }
    Console.WriteLine("Sum od Digits: " + SumOfDigits);
        }
        //Task 7
        static double LengthOfCircle(double Radius)
        {
            return Radius = Math.PI * 4;
        }
        static double ShapeOfCircle(double Radius)
        {
            return Math.PI * Radius * Radius;
        }
        //Task 9
        static void Eu(double max)
        {
            double u1 = 10;
            double r1 = 40;
            double u2 = 5;
            double r2 = 40;

            if (u1 / r1 < u2 / r2) {
                Console.WriteLine("First ");
            } 
            else {
                Console.WriteLine("Second ");
            }
            //Task 8
            static void density(double massa)
            {
                double p1;
                double p2;
                double m1 = 10;
                double m2 = 30;
                double v1 = 40;
                double v2 = 5;
                p1 = m1 / v1;
                p2 = m2 / v2;
                if (p1 > p2)
                {
                    Console.WriteLine("плотность первого больше");
                }
                else
                {
                    Console.WriteLine("плотность второго больше");
                }

            }
        }
    }
    
}
