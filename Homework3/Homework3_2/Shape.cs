using System;
using System.Numerics;

namespace Homework3_1
{
    /* 
     * Shape的子类通过2或3个点来定义一个图形
     * 当这2个3个点不符合相关图形定义（如：使得正方形长宽不相等）时，该图形的width/height/side等字段将不会被赋值（即，使用初始值0）
     * 其面积也不会参与最后的总面积计算
     */
    interface ILegal
    {
        bool IsLegal();
    }

    public abstract class Shape : ILegal
    {
        public abstract float Area { get; }
        public abstract bool IsLegal();
    }

    public class Triangle : Shape
    {
        private Vector2[] dot = new Vector2[3];
        private float width;
        private float height;

        public Triangle(Vector2 dot1, Vector2 dot2, Vector2 dot3)
        {
            dot[0] = dot1; dot[1] = dot2; dot[2] = dot3;

            if (IsLegal())
            {
                Vector2 vector1 = dot[0] - dot[1];
                Vector2 vector2 = dot[2] - dot[1];
                Vector2 vHeight = vector1 - vector2;
                this.width = vector1.Length();
                this.height = vHeight.Length();
            }
        }

        public Triangle(float x1, float y1, float x2, float y2, float x3, float y3)
        {
            dot[0].X = x1; dot[0].Y = y1;
            dot[1].X = x2; dot[1].Y = y2;
            dot[2].X = x3; dot[2].Y = y3;
            if (IsLegal())
            {
                Vector2 vector1 = dot[0] - dot[1];
                Vector2 vector2 = dot[2] - dot[1];
                Vector2 vHeight = vector1 - vector2;
                this.width = vector1.Length();
                this.height = vHeight.Length();
            }
            else
                throw new Exception("The shape is illegal.");
        }

        override public bool IsLegal()
        {
            if (dot[0] == dot[1] || dot[1] == dot[2] || dot[2] == dot[0])
                return false;
            else
                return true;
        }

        override public float Area
        {
            get => width * height / 2;
        }
    }

    public class Rectangle : Shape
    {
        private Vector2[] dot = new Vector2[2];
        private float width;
        private float height;

        public Rectangle(Vector2 dot1, Vector2 dot2)
        {
            dot[0] = dot1; dot[1] = dot2;

            if (IsLegal())
            {
                width = Math.Abs(dot[0].X - dot[1].X);
                height = Math.Abs(dot[0].Y - dot[1].Y);
            }
        }

        public Rectangle(float x1, float y1, float x2, float y2)
        {
            dot[0].X = x1; dot[0].Y = y1;
            dot[1].X = x2; dot[1].Y = y2;
            if (IsLegal())
            {
                width = Math.Abs(dot[0].X - dot[1].X);
                height = Math.Abs(dot[0].Y - dot[1].Y);
            }
            else
                throw new Exception("The shape is illegal.");
        }

        override public bool IsLegal()
        {
            if (dot[0] == dot[1])
                return false;
            else
                return true;
        }

        override public float Area
        {
            get => width * height;
        }
    }

    public class Square : Shape
    {
        private Vector2[] dot = new Vector2[2];
        private float side;

        public Square(Vector2 dot1, Vector2 dot2)
        {
            dot[0] = dot1; dot[1] = dot2;

            if (IsLegal())
                side = Math.Abs(dot[0].X - dot[1].X);
        }

        public Square(float x1, float y1, float x2, float y2)
        {
            dot[0].X = x1; dot[0].Y = y1;
            dot[1].X = x2; dot[1].Y = y2;
            if (IsLegal())
                side = Math.Abs(dot[0].X - dot[1].X);
            else
                throw new Exception("The shape is illegal.");
        }

        override public bool IsLegal()
        {
            if (dot[0] == dot[1] || Math.Abs(dot[0].X - dot[1].X) != Math.Abs(dot[0].Y - dot[1].Y))
                return false;
            else
                return true;
        }

        override public float Area
        {
            get => side * side;
        }
    }
}
