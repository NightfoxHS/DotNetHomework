using System;

namespace Homework1_Console
{
    class Calculate
    {
        private string str;
        private float num1, num2;
        private char symbol;
        public Calculate(string str)
        {
            this.str = str;
        }
        public void setStr(string str)
        {
            this.str = str;
        }
        public string getStr()
        {
            return this.str;
        }
        public bool getResult(ref float result)
        {
            bool flag = false;
            char[] exp_set = { '+', '-', '*', '/', '%' };
            foreach (char x in exp_set)
            {
                if (str.Contains(x))
                {
                    string[] exp = this.str.Split(x, 2);
                    this.num1 = float.Parse(exp[0]);
                    this.num2 = float.Parse(exp[1]);
                    this.symbol = x;
                    flag = true;
                    break;
                }
            }
            switch (this.symbol)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                case '%':
                    result = num1 % num2;
                    break;
                default:
                    return flag;
            }
            return flag;
        }
        static void Main(string[] args)
        {
            Calculate Calculator = new Calculate("");
            bool flag = true;
            float result = 0;
            do
            {
                Console.WriteLine("Enter your expression:(+-*/%,'q' to quit)");
                Calculator.setStr(Console.ReadLine());
                if (string.Equals(Calculator.getStr(), "q"))
                    flag = false;
                if (flag)
                    if (Calculator.getResult(ref result))
                        Console.WriteLine(result);
            } while (flag);
        }
    }
}
