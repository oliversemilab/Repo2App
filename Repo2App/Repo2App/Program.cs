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
            System.Console.WriteLine("Hmm");
            RandomFunctionBox1 RFB = new RandomFunctionBox1();
            RFB.MagicNumber = 50;
            System.Console.WriteLine(RFB.MagicNumber);
            RFB.MagicNumber = 150;
            System.Console.WriteLine(RFB.MagicNumber);
            RFB.MagicNumber = 80;
            System.Console.WriteLine(RFB.MagicNumber);
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
        public delegate int NumberReturner();
        public static int NumberFunction() { return 5; }

        private int _MagicNumber;
        public int MagicNumber
        {
            get { System.Console.WriteLine("get Running"); ;  return _MagicNumber; }
            set
            {
                if (value > 100 || value < 0)
                {
                    _MagicNumber = 42;
                }
                else
                {
                    _MagicNumber = value;
                }
            }
        }
    }

    class RandomFunctionBox2 : ICountable, IColorable
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
        int GetCounter();
        void SetCounter(int n);
        void DoubleCounter();
    }
}
