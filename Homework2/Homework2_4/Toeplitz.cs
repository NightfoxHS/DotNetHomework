using System;

namespace Homework2_4
{
    class Toeplitz
    {
        public static int[,] CreateMatrix(int M, int N)
        {
            try
            {
                Console.WriteLine("Enter the content of matrix:(Every line use enter to split)");
                int[,] retVal = new int[M,N];
                string[] str;
                for (int i = 0; i < M; i++)
                {
                    str = Console.ReadLine().Split(' ', N);
                    for (int j = 0; j < N; j++)
                    {
                        retVal[i,j] = Int32.Parse(str[j]);
                    }
                }
                return retVal;
            }
            catch(Exception e)
            {
                Console.WriteLine("error:{0}", e.Message);
                return null;
            }
        }
        public static bool IsToeplitz(int[,] matrix)
        {
            bool flag = true;
            int M = matrix.GetLength(0);
            int N = matrix.GetLength(1);
            int x = 0, y = 0;
            for (int i=0;i<M-2;i++)
            {
                x = i;
                y = 0;
                while (y < N-2)
                {
                    if (matrix[x,y] != matrix[x + 1,y + 1])
                    {
                        flag = false;
                        break;
                    }
                    else
                    {
                        x++;
                        y++;
                    }
                }
                if (flag == false)
                    break;
            }
            return flag;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the matrix size:(M N)");
            string[] str = Console.ReadLine().Split(' ',2);
            int M = Int32.Parse(str[0]);
            int N = Int32.Parse(str[1]);
            int[,] matrix = CreateMatrix(M, N);
            bool isToep = false;
            if (matrix != null)
                isToep = IsToeplitz(matrix);
            Console.WriteLine("This matrix is{0}a Toeplitz matrix.", isToep ? " " : " not ");
        }
    }
}
