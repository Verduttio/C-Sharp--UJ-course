using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia4
{
    interface ICalculator<T>
    {
        T Add(T a, T b);
        T Multiply(T a, T b);
        bool EqualsZero(T a);

    }

    class IntCalculator : ICalculator<int>
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public bool EqualsZero(int a)
        {
            return a == 0;
        }

    }

    class DoubleCalculator : ICalculator<double>
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public bool EqualsZero(double a)
        {
            return a == 0;
        }
    }

    class FloatCalculator : ICalculator<float>
    {
        public float Add(float a, float b)
        {
            return a + b;
        }

        public float Multiply(float a, float b)
        {
            return a * b;
        }

        public bool EqualsZero(float a)
        {
            return a == 0;
        }

    }


    static class Calculators
    {
        public static ICalculator<T> GetInstance<T>()
        {
            if (typeof(T) == typeof(int)) return (ICalculator<T>)new IntCalculator();
            else if (typeof(T) == typeof(double)) return (ICalculator<T>)new DoubleCalculator();
            else if (typeof(T) == typeof(float)) return (ICalculator<T>)new FloatCalculator();
            else
            {
                Console.WriteLine("Unsupported variable type (do Zadanie 5)");
                return null;
            }
        }
    }


}
