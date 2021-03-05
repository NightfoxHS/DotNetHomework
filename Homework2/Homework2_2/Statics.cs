using System;

namespace Homework2_2
{
    class Statics
    {
        private int[] nums;
        private int n; // The number of data
        public Statics(int n)
        {
            this.n = n;
            this.nums = new int[n];
        }
        public void GetStatics()
        {
            Console.WriteLine("Enter your data:(use space to split, and enter to finish)");
            string[] str = Console.ReadLine().Split(' ', this.n);
            for (int i = 0; i < this.n; i++)
                this.nums[i] = Int32.Parse(str[i]);
        }
        public void GetRes(out float avg,out int max,out int min)
        {
            int sum = 0;
            min = Int32.MaxValue;
            max = Int32.MinValue;
            foreach (int x in nums)
            {
                if (x > max)
                    max = x;
                if (x < min)
                    min = x;
                sum += x;
            }
            avg = sum / this.n;
        }
        public void Display()
        {
            foreach (int x in this.nums)
                Console.Write($"{x} ");
            Console.Write('\n');
        }
        public void FillArray() // 测试效果用
        {
            Random rd = new Random(new Guid().GetHashCode());
            for (int i = 0; i < this.n; i++)
                nums[i] = rd.Next(1, 100);
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number of data:");
                Statics sta = new Statics(Int32.Parse(Console.ReadLine()));
                //sta.FillArray();
                sta.GetStatics();
                sta.GetRes(out float avg, out int max, out int min);
                Console.Write("avg:{0}\nmin:{1}\nmax:{2}", avg, min, max);
            }
            catch (Exception e)
            {
                Console.WriteLine("error:{0}", e.Message);
            }
        }
    }
}

