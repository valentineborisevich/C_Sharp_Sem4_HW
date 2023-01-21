// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (без использования Math.Pow)

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.WriteLine("Enter two numbers (A and B) and I will return A in B extent. Enter number A");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number B");
// int b = Convert.ToInt32(Console.ReadLine());
// int mult = 1;
// for (int i = 0; i < b; i++)
// {
//     mult *= a;
// }
// Console.WriteLine(mult);
int MLTPL(int number1, int number2)
{
    int mult = 1;
    for (int i = 0; i < number2; i++)
    {
        mult *= number1;
    }
    return mult;
}

Console.WriteLine("Enter two numbers (A and B) and I will return A in B extent. Enter number A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number B");
int b = Convert.ToInt32(Console.ReadLine());
int c = MLTPL(a, b);
Console.WriteLine(c);