using System;

namespace Homework4_1
{
    public class MyList<T>
    {
        public class Node<_T>
        {
            public Node<_T> Next { get; set; }
            public _T Data { get; set; }

            public Node(_T t)
            {
                Next = null;
                Data = t;
            }
        }

        private Node<T> head;
        private Node<T> tail;

        public Node<T> Head { get => head; }
        public Node<T> Tail { get => tail; }

        public MyList()
        {
            head = tail = null;
        }

        public void Add(T t)
        {
            Node<T> node = new Node<T>(t);
            if (tail == null)
                head = tail = node;
            else
            {
                tail.Next = node;
                tail = node;
            }
        }

        public void ForEach(Action<T> action)
        {
            try
            {
                Node<T> p = Head;
                while (p.Next != null)
                {
                    action(p.Data);
                    p = p.Next;
                }
                action(Tail.Data);
            }
            catch(Exception e)
            {
                Console.WriteLine($"error:{e.Message}");
            }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            for (int i = 0; i < 10; i++)
                myList.Add(i);

            Action<int> print = n => Console.Write($"{n} ");
            myList.ForEach(print);
            Console.Write('\n');

            int max = Int32.MinValue;
            Action<int> getMax = n => { if (n > max) max = n; };
            myList.ForEach(getMax);

            int min = Int32.MaxValue;
            Action<int> getMin = n => { if (n < min) min = n; };
            myList.ForEach(getMin);

            int sum = 0;
            Action<int> getSum = n => sum += n;
            myList.ForEach(getSum);

            Console.WriteLine($"Max:{max} Min:{min} Sum:{sum}");
        }
    }
}
