// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

int[] array = new int[5];

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {   
        Console.Write($"Введите число {i} ->");
        arr[i] = int.Parse(Console.ReadLine());
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int FindSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        sum++;
    }
    return sum;
}
FillArray(array);
PrintArray(array);
int result = FindSum(array);
Console.WriteLine($"Количество {result}");