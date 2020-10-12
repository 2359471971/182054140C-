using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equal
{
    class Program
    {
        static void Main(string[] args)
        {
            Count co = new Count();
            co.InPut();
            Console.WriteLine(co.Count2());
            co.Equals(co.NumOne, co.NumTwo);
            if (co.Equals(co.NumOne, co.NumTwo))
                Console.WriteLine("两数相等");
            else
                Console.WriteLine("两数不相等");
        }
    }
    abstract class Count1 
    {
        protected int numOne;
        protected int numTwo;
        public int NumOne
        {
            get { return numOne; }
            set { numOne = value; }
        }

        public int NumTwo
        {
            get { return numTwo; }
            set { numTwo = value; }
        }
        protected char _character;

        public char Character
        {
            get { return _character; }
            set { _character = value; }
        }
        abstract public double Count2();

        public bool Equals(int a, int b)
        {
            if (a == b)
                return true;
            else
                return false;
        }

    }
    class Count:Count1
    {
        public  void InPut()
        {
            Console.WriteLine("请输入第一个数");
            NumOne = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("请输入运算符");
            Character = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("请输入第二个数");
            NumTwo = Convert.ToInt16(Console.ReadLine());
        }
        public override double Count2()
        {
            if (Character == '+')
            {
                return NumOne + NumTwo;
            }
            else if (Character == '-')
            {
                return NumOne - NumTwo;
            }
            else if (Character == '*')
            {
                return NumOne * NumTwo;
            }
            else if (Character == '/')
            {
                double d = (double)NumOne / NumTwo;
                return d;
            }
            else if (Character == '%')
            {
                double d = (double)NumOne % NumTwo;
                return d;
            }
            else if (Character == '&')
            {
                String n1 = Convert.ToString(NumOne, 2);
                String n2 = Convert.ToString(NumTwo, 2);
                int lenth = Math.Min(n2.Length, n1.Length);
                char[] bresult = new char[lenth];
                for (int i = Math.Min(n1.Length, n2.Length) - 1; i >= 0; i--)
                {

                    if (n1[i] - 48 > 0 && n2[i] - 48 > 0)
                    {
                        bresult[i] = '1';
                    }
                    else
                    {
                        bresult[i] = '0';
                    }
                }
                String result = new String(bresult);
                return Convert.ToInt32(result, 2);
            }
            else return -1;
        }
        }
}
    
