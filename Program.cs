using Figures;
class Programm
{
    static void Main()
    {
        ConsoleKeyInfo key;
        while (true)
        {
            Console.WriteLine("Введите с какой фигурой взаимодействовать");
            Console.WriteLine("S - квадрат, R - прямоугольник, C - круг, T - треугольник");
            key = Console.ReadKey(true);
            switch (key.Key.ToString())
            {
                case "S":
                    Console.WriteLine("Введите длину одной стороны");
                    Square square = new Square();
                    square.Info(float.Parse(Console.ReadLine()));
                    Console.WriteLine($"Периметр квадрата {square.P()}");
                    Console.WriteLine($"Площадь квадрата {square.S()}");
                    break;
                case "R":
                    Rectangle rectangle = new Rectangle();
                    Console.WriteLine("Введите длину 2 сторон");
                    rectangle.Info(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
                    Console.WriteLine($"Периметр прямоугольника {rectangle.P()}");
                    Console.WriteLine($"Площадь прямоугольника {rectangle.S()}");
                    break;
                case "C":
                    Circle circle = new Circle();
                    Console.WriteLine("Введите радиус");
                    circle.Info(float.Parse(Console.ReadLine()));
                    Console.WriteLine($"Периметр круга {circle.P()}");
                    Console.WriteLine($"Площадь круга {circle.S()}");
                    break;
                case "T":
                    Triangle triangle = new Triangle();
                    Console.WriteLine("Введите длинну 3 сторон треугольника");
                    triangle.Info(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
                    triangle.ShowResults();
                    break;
            }
        }
    }
}