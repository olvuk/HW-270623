double inputNumber(string message) 
{
    Console.WriteLine(message);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

double findX(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double findY(double k1, double b1, double x)
{
    double y = k1 * x + b1;
    return y;
}

double k1 = inputNumber("Введите число k1");
double b1 = inputNumber("Введите число b1");
double k2 = inputNumber("Введите число k2");
double b2 = inputNumber("Введите число b2");
double x = findX(k1, b1, k2, b2);
double y = findY(k1, b1, x);
Console.WriteLine($"Точка пересечения: {x}, {y}");


