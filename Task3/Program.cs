
int inputNum()
{
    Console.WriteLine("Введите число для возведения в куб ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int clculation(int num)
{
    int count = 1;
    while (count <= num)
    {
        int result = Convert.ToInt32(Math.Pow(count, 3));
        if (count % 5 != 0)
        {
            Console.Write($"{result}\t");
        }
        else
        {
            Console.WriteLine($"{result}");
        }
        count++;
    }
    return 0;
}
clculation(inputNum());
