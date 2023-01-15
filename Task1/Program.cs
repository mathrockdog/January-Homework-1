// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Exponent(int A, int B)
    {
      int C = 1;
      for(int i = 1; i <= B; i++)
        {
          C = C * A;
        } 
        return C;
    }

Console.WriteLine("Введите первое число:");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int B = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponent(A, B);
Console.WriteLine(exponentiation);