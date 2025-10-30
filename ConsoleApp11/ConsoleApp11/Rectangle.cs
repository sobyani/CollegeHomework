namespace ConsoleApp11
{
    internal class Rectangle
    {
        private double _width;
        private double _height;

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    Console.WriteLine("Ошибка: ширина должна быть положительным числом!");
                }
            }
        }

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                {
                    Console.WriteLine("Ошибка: высота должна быть положительным числом!");
                }
            }
        }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double GetArea()
        {
            return _width * _height;
        }

        public double GetPerimeter()
        {
            return 2 * (_width + _height);
        }
    }
}
