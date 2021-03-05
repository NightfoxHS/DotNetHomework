using System;
using System.Collections.Generic;

namespace Homework2_1
{
    class PrimeFactor
    {
        private int num;
        public PrimeFactor(int n)
        {
            this.num = n;
        }
        public static bool IsPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        public List<int> GetRes()
        {
            List<int> res = new List<int>();
            int i = 2;
            while (i <= num)
            {
                while (num % i == 0)
                {
                    num /= i;
                    res.Add(i);
                }
                do
                {
                    i++;
                } while (!IsPrime(i));
            }
            return res;
        }
        static void Main(string[] args)
        {
            bool flag = true;
            do
            {
                try
                {
                    Console.WriteLine("Enter the number:(q to quit)");
                    string str = Console.ReadLine();
                    if (!str.Equals("q"))
                    {
                        int n = Int32.Parse(str);
                        PrimeFactor fac = new PrimeFactor(n);
                        List<int> res = fac.GetRes();
                        for (int i = 0; i < res.Count - 1; i++)
                            Console.Write($"{res[i]}*");
                        Console.Write(res[res.Count - 1]);
                    }
                    else
                        flag = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("error:{0}", e.Message);
                }
            } while (flag);
        }
    }
}
