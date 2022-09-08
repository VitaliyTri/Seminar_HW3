// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
int i = 0;
int N = number.Length;

if (number.Length == 5 && number[i] == number[N - 1] && number[i + 1] == number[N - 2])
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else if (number.Length != 5)
{
    Console.WriteLine($"Число НЕ пятизначное!!");
}

else Console.WriteLine($"Число {number} НЕ является палиндромом");
