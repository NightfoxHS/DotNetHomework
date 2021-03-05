using System;
using System.Collections.Generic;

namespace Homework2_3
{
    class Eratosthenes
    {
        private List<int> listOfNum;
        public int n; // The number of List element
        public Eratosthenes(int n)
        {
            this.listOfNum = new List<int>();
            this.n = n;
            for (int i = 2; i <= this.n; i++)
                this.listOfNum.Add(i);
        }
        public static bool IsPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        public void DeleteNums(int n)
        {
            for(int i=2;n*i<=this.n;i++)
                if (this.listOfNum.Contains(n * i))
                {
                    this.listOfNum.Remove(n * i);
                }
        }
        public void DisplayList()
        {
            Console.WriteLine("The prime between 2 and {0}:", this.n);
            foreach (int x in this.listOfNum)
                Console.Write($"{x} ");
        }
        static void Main(string[] args)
        {
            Eratosthenes era = new Eratosthenes(100);
            for (int i = 2; i <= Math.Sqrt(era.n); i++)
            {
                if (!IsPrime(i))
                    continue;
                era.DeleteNums(i);
            }
            era.DisplayList();
        }
    }
}
