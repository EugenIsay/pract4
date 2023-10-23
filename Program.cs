using Figures;
class Programm
{
    static void Main()
    {
        Proverka read = new Proverka();
        ConsoleKeyInfo key;
        while (true)
        {
            Console.WriteLine("Введите с какой фигурой взаимодействовать");
            Console.WriteLine("S - квадрат, R - прямоугольник, C - круг, T - треугольник, P - пирамида");
            key = Console.ReadKey(true);
            switch (key.Key.ToString())
            {
                case "S":
                    Square square = new Square();
                    Console.WriteLine("Введите длину одной стороны");
                    read.read_show(out float a1);
                    square.Info(a1);
                    square.ShowResult();
                    break;
                case "R":
                    Rectangle rectangle = new Rectangle();
                    Console.WriteLine("Введите длину 2 сторон");
                    read.read_show(out float b1, out float b2);
                    rectangle.Info(b1, b2);
                    rectangle.ShowResult();
                    break;
                case "C":
                    Circle circle = new Circle();
                    Console.WriteLine("Введите радиус");
                    read.read_show(out float c1);
                    circle.Info(c1);
                    circle.ShowResult();
                    break;
                case "T":
                    Triangle triangle = new Triangle();
                    Console.WriteLine("Введите длинну 3 сторон треугольника");
                    read.read_show(out float d1, out float d2, out float d3);
                    triangle.Info(d1, d2, d3);
                    triangle.ShowResults();
                    break;
                case "P":
                    Pyramid pyramid = new Pyramid();
                    Console.WriteLine("Выбиретие, какое основание у пирамиды");
                    Console.WriteLine("С - круг, M - многоугольник");
                    key = Console.ReadKey(true);
                    switch (key.Key.ToString()) 
                    {
                        case "C":
                            Console.WriteLine("Введите радиус и высоту");
                            read.read_show(out float e1, out float e2);
                            pyramid.Info(e1, e2);
                            pyramid.ShowResults();
                            break;
                        case "M":
                            Console.WriteLine("Введите длинну 1 стороны, количество сторон у основания и высоту");
                            read.read_show(out float f1, out float f2, out float f3);
                            if (f2 >= 3)
                            {
                                pyramid.Info(f1, f2, f3);
                                pyramid.ShowResults();
                            }
                            break;
                    }
                    break;
            }
        }
    }
}