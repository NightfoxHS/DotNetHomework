using System;
using System.Numerics;
using System.Collections.Generic;
using Homework3_1;

namespace Homework3_2
{
    enum ShapeType { Triangle, Rectangle, Square };
    class ShapeFactory
    {
        public static Shape CreateShape(ShapeType shape,Vector2[] dot)
        {
            switch (shape)
            {
                case ShapeType.Triangle:
                    return new Triangle(dot[0],dot[1],dot[2]);
                case ShapeType.Rectangle:
                    return new Rectangle(dot[0], dot[1]);
                case ShapeType.Square:
                    return new Square(dot[0], dot[1]);
                default:
                    return null;
            }
        }

        public static void GetRandomDots(Vector2[] dots)
        {
            Random rd = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < dots.Length; i++)
            {
                dots[i].X = rd.Next(1, 30);
                dots[i].Y = rd.Next(1, 30);
            }
        }

        public static List<Shape> GetRandomShapes(int n)
        {
            Random rd = new Random(Guid.NewGuid().GetHashCode());
            List<Shape> shapes = new List<Shape>();
            for (int i = 0; i < n; i++)
            {
                int type = rd.Next(1, 4);
                switch (type)
                {
                    case 1:
                        Vector2[] dots1 = new Vector2[3];
                        GetRandomDots(dots1);
                        shapes.Add(CreateShape(ShapeType.Triangle, dots1));
                        break;
                    case 2:
                        Vector2[] dots2 = new Vector2[2];
                        GetRandomDots(dots2);
                        shapes.Add(CreateShape(ShapeType.Rectangle, dots2));
                        break;
                    case 3:
                        Vector2[] dots3 = new Vector2[2];
                        GetRandomDots(dots3);
                        shapes.Add(CreateShape(ShapeType.Square, dots3));
                        break;
                    default:
                        break;
                }
            }
            return shapes;
        }

        public static void DisplayShape(List<Shape> shapes)
        {
            float sum = 0;
            foreach(Shape x in shapes)
            {
                if (x.IsLegal())
                {
                    Console.WriteLine($"Type:{x.GetType()} Area:{x.Area}");
                    sum += x.Area;
                }
            }
            Console.WriteLine($"AreaSum:{sum}");
        }

        public static void Main(string[] args)
        {
            /* 
             * 此程序通过2或3个点来生成随机图形
             * 当这2个3个点不符合相关图形定义（如：使得正方形长宽不相等）时，该图形将不会被输出至Console
             * 其面积也不会参与最后的总面积计算
             * 基于以上原因，该程序将会较少地生成正方形(Square)，因其合法的条件较为苛刻
             */
            try
            {
                List<Shape> shapes = GetRandomShapes(10);
                DisplayShape(shapes);
            }
            catch(Exception e)
            {
                Console.WriteLine("error:{0}", e.Message);
            }
        }
    }
}
