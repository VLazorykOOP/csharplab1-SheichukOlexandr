// See https://aka.ms/new-console-template for more information
using System.Text;


using System;
class Program
    
{
    static void Main(string[] args)

    {
        Console.WriteLine("Натиснiть будь-яку кнопку для вiдображення меню...");
        Console.ReadKey(true); 
        int choice;

        do
        {
            Console.Clear(); 
            Console.WriteLine("Меню вибору:");
            Console.WriteLine("1. Обчислення площi кiльця");
            Console.WriteLine("2. Визначення iснування трикутника");
            Console.WriteLine("3. Визначення положення точки в системi координат");
            Console.WriteLine("4. Визначення максимальноi швидкостi транспортного засобу");
            Console.WriteLine("5. Пiднесення числа до кубу");
            Console.WriteLine("6. Обчислення виразу");
            Console.WriteLine("0. Вихiд");
            Console.Write("Оберiть завдання: ");
            choice = int.Parse(Console.ReadLine());

            Console.Clear(); 

            switch (choice)
            {
                case 1:
                    CalculateRingArea();
                    break;
                case 2:
                    CheckTriangleExistence();
                    break;
                case 3:
                    CheckPointPosition();
                    break;
                case 4:
                    CheckMaxSpeed();
                    break;
                case 5:
                    CubeFunction();
                    break;
                case 6:
                    CalculatingAnExpression();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Невiрний вибiр. Спробуйте ще раз.");
                    break;
            }

            if (choice != 0) 
            {
                Console.WriteLine("\nНатиснiть будь-яку кнопку для продовження...");
                Console.ReadKey(true);
            }

        } while (choice != 0);
    }

    static void CalculateRingArea()
    {
        Console.Write("Введiть внутрiшнiй радiус (r1): ");
        double r1 = double.Parse(Console.ReadLine());
        Console.Write("Введiть зовнiшнiй радiус (r2): ");
        double r2 = double.Parse(Console.ReadLine());

        double area = Math.PI * (r2 * r2 - r1 * r1);
        Console.WriteLine($"Площа кiльця з внутрiшнiм радiусом {r1} i зовнiшнiм радiусом {r2} дорiвнює {area}");
    }

    static void CheckTriangleExistence()
    {
        Console.Write("Введiть довжину сторони a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введiть довжину сторони b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Введiть довжину сторони c: ");
        double c = double.Parse(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
            Console.WriteLine("Трикутник iснує");
        else
            Console.WriteLine("Трикутник не iснує");
    }

    static void CheckPointPosition()
    {
        Console.Write("Введiть x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Введiть y: ");
        double y = double.Parse(Console.ReadLine());

        bool insideSquare = Math.Abs(x) <= 50 && Math.Abs(y) <= 50;
        bool aboveParabola = y >= -x * x + 100;
        bool aboveLine = y >= -15;

        if (insideSquare && aboveParabola && aboveLine)
            Console.WriteLine("Точка знаходиться всерединi фiгури");
        else if (!insideSquare || !aboveParabola || !aboveLine)
            Console.WriteLine("Точка знаходиться поза фiгурою");
        else
            Console.WriteLine("Точка знаходиться на межi фiгури");
    }

    static void CheckMaxSpeed()
    {
        Console.WriteLine("Доступнi ознаки транспортних засобiв: а - автомобiль, b - велосипед, c - мотоцикл, d - лiтак, e - поiзд. (Англiйською)");
        Console.Write("Введiть ознаку транспортного засобу: ");
        char vehicle = char.ToLower(Console.ReadKey().KeyChar);

        int maxSpeed;
        switch (vehicle)
        {
            case 'a':
                maxSpeed = 180;
                break;
            case 'b':
                maxSpeed = 30;
                break;
            case 'c':
                maxSpeed = 200;
                break;
            case 'd':
                maxSpeed = 900;
                break;
            case 'e':
                maxSpeed = 300;
                break;
            default:
                maxSpeed = -1;
                break;
        }

        if (maxSpeed != -1)
            Console.WriteLine($"\nМаксимальна швидкiсть транспортного засобу: {maxSpeed} км/год");
        else
            Console.WriteLine("\nДля введеноi ознаки транспортного засобу максимальна швидкiсть не визначена");
    }

    static void CubeFunction()
    {
        Console.Write("Введiть цiле число: ");
        int num = int.Parse(Console.ReadLine());

        int result = Cube(num);
        Console.WriteLine($"Куб числа {num} дорiвнює {result}");
    }

    static int Cube(int num)
    {
        return num * num * num;
    }

    static void CalculatingAnExpression()
    {
        // Введення значень з клавіатури
        Console.Write("Введiть значення x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Введiть значення y: ");
        double y = double.Parse(Console.ReadLine());

        // Обчислення значення виразу
        double result = (1 / (x * y) + 1 / (Math.Pow(x, 2) + 1)) * (x + y);

        // Виведення результату на екран
        Console.WriteLine("Значення виразу: " + result);
    }
}
