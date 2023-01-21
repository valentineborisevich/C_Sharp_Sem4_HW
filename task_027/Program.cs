// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12



// int SumOfDigits(int number)
// {
//     string array = Convert.ToString(number);
//     int Length = array.Length;
//     int sum = 0;
//     for (int index = 1; index < Length; index++)
//     {
//         sum = sum + array[index];
//     }
// }
// Console.WriteLine("Enter any number and I will return sum of it's digits.");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SumOfDigits(a));


Console.WriteLine("Enter any number and I will return sum of it's digits.");
var a = Console.ReadLine();
var array = Array.ConvertAll(a.ToString().ToCharArray(), x=> (int)Char.GetNumericValue(x));
int Length = array.Length;
int sum = 0;
for (int i = 0; i < Length; i++)
{
    sum = sum + array[i];
}
Console.WriteLine(sum);
