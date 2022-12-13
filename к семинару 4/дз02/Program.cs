// Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
int Sum(int num)
{
    int result = 0;
    result += num % 10;
    num /= 10;
    if (num > 0)
    {
        result += Sum(num);
    }
    return result;
}
int sum = Sum(number);
Console.WriteLine($"Сумма чисел равна {sum}");
