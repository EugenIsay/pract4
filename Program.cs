using Figures;
class Programm
{
    static void Main()
    {
        ConsoleKeyInfo key;
        while (true)
        {
            Console.WriteLine("Введите с какой фигурой взаимодействовать");
            Console.WriteLine("S - квадрат, R - прямоугольник, C - круг, T - треугольник, P - круг");
            key = Console.ReadKey(true);
            switch (key.Key.ToString())
            {
                case "S":
                    Square square = new Square();
                    Console.WriteLine("Введите длину одной стороны");
                    square.Info(float.Parse(Console.ReadLine()));
                    square.ShowResult();
                    break;
                case "R":
                    Rectangle rectangle = new Rectangle();
                    Console.WriteLine("Введите длину 2 сторон");
                    rectangle.Info(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
                    rectangle.ShowResult();
                    break;
                case "C":
                    Circle circle = new Circle();
                    Console.WriteLine("Введите радиус");
                    circle.Info(float.Parse(Console.ReadLine()));
                    circle.ShowResult();
                    break;
                case "T":
                    Triangle triangle = new Triangle();
                    Console.WriteLine("Введите длинну 3 сторон треугольника");
                    triangle.Info(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
                    triangle.ShowResults();
                    break;
                case "P":
                    Pyramid pyramid = new Pyramid();
                    Console.WriteLine("Введите длинну 1 стороны, количество сторон у основания и высоту");
                    pyramid.Info(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
                    pyramid.ShowResults();
                    break;
            }
        }
    }
}