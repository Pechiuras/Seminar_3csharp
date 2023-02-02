//Task21
Console.Clear();
Console.Write("Введите Х1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double l = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 2);
Console.WriteLine(l);