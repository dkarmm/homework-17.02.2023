// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool result(int number)
{
    int firstTwoDigit = number / 1000;
    int lastTwoDigit = (number % 10 * 10) + (number % 100 / 10);
    if (firstTwoDigit == lastTwoDigit)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99999 || number < 10000)
{
    Console.WriteLine("Число не является пятизначным.");
}
bool showResult = result(number);
Console.WriteLine(showResult);