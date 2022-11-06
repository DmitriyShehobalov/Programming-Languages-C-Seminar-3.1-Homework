// Задача 19
// 1. Напишите программу, которая принимает на вход пятизначное число и 
// 2.проверяет, является ли оно палиндромом.
// 3.Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да
int CheckingNum(int number)
{
    int res = default;
    for (int i = 0; i < number; i++)
    {
        int lastNumber = number % 10;
        int firstNumber = number / 10000;
        if (firstNumber == lastNumber)
        {
            for (int j = 0; j < number; j++)
            {
                int fourNumber = (number / 10) % 10;
                int secondNumber = (number / 1000) % 10;
                if (secondNumber == fourNumber) return res = 1;
            }
        }
        else return res = 0;
    }
    return res;
}
Console.Write("Enter five digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 10000 || num >= 99999) Console.Write("Enter a correct number: ");
else
{
    int result = CheckingNum(num);
    Console.WriteLine(result > 0 ? $"The Number {num} is a polindrome" : $" The number {num} is not a polindrome");
}



