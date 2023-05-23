// Чаков С.В. GitHub https://github.com/StChak/Noris.git
// ДЗ_3 Базовые алгоритмы C#. Задача 19. На входе пятизначное число - на выходе проверяет, является ли оно палиндромом: Да или Нет.
/*
Console.WriteLine("Task 19 Palindrome or not");

void PalindromeRecognizer()

{
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number < 0)
  {
    user_number = user_number * (-1);
  }
      if (user_number > 99999 || user_number < 10000)
      {
        Console.WriteLine("Your number is not valide!");
      }
      else
      {
        int first_number = user_number / 10000;
        int fifth_number = user_number % 10;
        int second_number = user_number / 1000 % 10;
        int fourth_number = user_number /10 % 10;
    
      if (first_number == fifth_number && second_number == fourth_number)
      {
        Console.WriteLine("Yes, it is palindrome numer");
      }
      else
      {
        Console.WriteLine("No, it is not palindrome numer");
      }
  }
}

Console.WriteLine("Input five - digit number: XXXXX ");

PalindromeRecognizer();
*/




//----------------------------------------------------------------------------------------------------------------------------------
/*
Console.WriteLine("Task 21. Input in 3D coordinats: A(x1,y1,z1); B(x2,y2,z2) - find the length AB");

double LongLine(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double lengthAB = MathF.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
    double lengthABround = Math.Round (lengthAB, 2);
    Console.WriteLine(Math.Round(lengthABround, 2));
    return lengthABround;
}

Console.WriteLine("Input X coordinat of A : ");
int xCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coordinat of A : ");
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Z coordinat of A : ");
int zCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input X coordinat of B : ");
int xCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coordinat of B : ");
int yCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Z coordinat of B : ");
int zCoordB = Convert.ToInt32(Console.ReadLine());

double dist = LongLine(xCoordA, xCoordB, yCoordA, yCoordB, zCoordA, zCoordB);

// Console.WriteLine($"Distnce AB is {dist:f2}");
*/




//---------------------------------------------------------------------------------------------------------------------------------------
/*
Console.WriteLine("Task 23. Input number N, return the cube of numbers from 1 to N");

void SquareFinder1 (int numberN)
{   
        int current_i = 1;
        while(current_i <= numberN)
            {
                int degree = 3; 
                double res = Math.Pow(current_i,degree);
                Console.Write($"{res:f0}, ");
                current_i ++;
            }
        Console.WriteLine("\b\b ");
}

void SquareFinder2(int numberN)
{
    int current_i = 1;
    while (current_i >= numberN)
    {
        Console.Write(current_i*current_i*current_i + ", ");
        current_i --;
    }
    Console.WriteLine("\b\b ");    
}
Console.WriteLine("Input number: ");
int user_numberN = Convert.ToInt32(Console.ReadLine());

if (user_numberN > 0)
    SquareFinder1(user_numberN);
else 
   SquareFinder2(user_numberN);
   */




   //*********************************************************************************************************************************