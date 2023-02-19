// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
//AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
string[] pointName = { "X-1", "Y-1", "Z-1", "X-2", "Y-2", "Z-2" };


int count = 0;

Dictionary<string, double> inputXYZ()
{
    var linesOfCord = new Dictionary<string, double>();
    Console.WriteLine("Все введеные значения должны иметь тип Double например 12,34 (,) именно запятая ");

    while (count < pointName.Length)
    {
        Console.Write($"Введите  точку  для {pointName[count]} ->");
        double currentPoint = Convert.ToDouble(Console.ReadLine());
        linesOfCord.Add(pointName[count], currentPoint);
        count++;
    }
    return linesOfCord;
}

double distanceCalculation(Dictionary<string, double> linesOfCor)
{
    double result = Math.Sqrt(Math.Pow((linesOfCor["X-1"] - linesOfCor["X-2"]), 2) + Math.Pow((linesOfCor["Y-1"] - linesOfCor["Y-2"]), 2) + Math.Pow((linesOfCor["Z-1"] - linesOfCor["Z-2"]), 2));
    result = Math.Round(result, 2);
    Console.WriteLine($"Растояние между точками равно :{result}");

    return result;
}


distanceCalculation(inputXYZ());
