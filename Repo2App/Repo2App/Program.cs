using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo2App
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World");
        }
    }

    class RandomFunctionBox1 : IColorable, ICountable
    {
        public static void Func01()
        {
            System.Console.WriteLine("Func01 Running");
        }

        public static void Func02()
        {
            System.Console.WriteLine("Func02 Running");
        }

        string Color;
        public void SetColor(string col)
        {
            Color = col;
        }
        public string GetColor()
        {
            return Color;
        }

        int Counter;
        public void DoubleCounter()
        {
            Counter *= 2;
        }
        public void SetCounter (int count)
        {
            Counter = count;
        }
        public int GetCounter()
        {
            return Counter;
        }
    }

    class RandomFunctionBox2
    {
        int Counter;
        public void DoubleCounter()
        {
            Counter *= 5;
        }
        public void SetCounter(int count)
        {
            Counter = count;
        }
        public int GetCounter()
        {
            return Counter;
        }
    }

    interface IColorable
    {
        string GetColor();
        void SetColor(string col);
    }

    interface ICountable
    {
        int GetCounter();
        void SetCounter(int n);
        void DoubleCounter();
    }
}
