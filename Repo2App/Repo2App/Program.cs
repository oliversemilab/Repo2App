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

    class RandomFunctionBox1 : IColorable
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
    }

    interface IColorable
    {
        string GetColor();
        void SetColor(string col);
    }

    interface ICountable
    {
        int GetCount();
        void SetCounter(int n);
        void DoubleCounter();
    }
}
