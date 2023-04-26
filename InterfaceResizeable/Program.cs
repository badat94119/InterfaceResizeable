using System;

namespace InterfaceResizeable
{
    interface Resizeable
    {
        double Area { get; }
        void Resize(double percent);
    }

    class Circle : Resizeable
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double Area
        {
            get { return Math.PI * radius * radius; }
        }

        public void Resize(double percent)
        {
            radius *= 1 + percent / 100;
        }
    }

    class Rectangle : Resizeable
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Area
        {
            get { return width * height; }
        }

        public void Resize(double percent)
        {
            width *= 1 + percent / 100;
            height *= 1 + percent / 100;
        }
    }

    class Square : Resizeable
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public double Side
        {
            get { return side; }
            set { side = value; }
        }

        public double Area
        {
            get { return side * side; }
        }

        public void Resize(double percent)
        {
            side *= 1 + percent / 100;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Resizeable[] shapes = new Resizeable[3];
            shapes[0] = new Circle(5);
            shapes[1] = new Rectangle(4, 6);
            shapes[2] = new Square(3);

            Random rand = new Random();

            foreach (var shape in shapes)
            {
                double percent = rand.Next(1, 101);
                Console.WriteLine($"Before resizing: {shape.Area}");
                shape.Resize(percent);
                Console.WriteLine($"After resizing: {shape.Area}");
            }

            Console.ReadLine();
        }
    }
}
