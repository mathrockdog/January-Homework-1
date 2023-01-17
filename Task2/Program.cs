// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

  int SumNumber(int number)
    {
    
        int counter = Convert.ToString(number).Length;
        int step = 0;
        int result = 0;

            for (int i = 0; i < counter; i++)
                {
                    step = number - number % 10;
                    result = result + (number - step);
                    number = number / 10;
                }
                    return result;
    }

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumnumber = SumNumber(number);
Console.WriteLine("Сумма цифр в числе равна: " + sumnumber);