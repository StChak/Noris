                        // GitHub https://github.com/StChak/Noris.git
// Задача 10 На входе 3-х значное число, а на выходе покажет вторую цифру этого числа (учитывая отрицательные)
/*
Console.WriteLine("Task 10");
void SecondDigitFinder(int user_number)
{
  if (user_number < 1000 && user_number > 99 || user_number > -1000 && user_number < -99)
     {
      user_number = user_number / 10 % 10;
      Console.WriteLine($"Your second digit is {user_number}");
     }
  else
     {
     Console.WriteLine("The number does not have 3 digits");
     }
}

Console.WriteLine("Enter your number: XXX ");
int user_number = Convert.ToInt32(Console.ReadLine());

SecondDigitFinder(user_number);
*/



//-----------------------------------------------------------------------------------------------------------------------------
// Задача 13 На входе число - на выходе 3я цифра числа или "третьей цифры нет"
/* 
Console.WriteLine("Task 13");
void TDig(int user_num)
{
    if (user_num > -100 && user_num < 100)
    {
        Console.WriteLine("Третьей цифры нет!");
    } 
    else
    {
        while (user_num >= 1000 || user_num <= -1000)
        {
            user_num = user_num / 10;
        }
        user_num = user_num % 10;
        Console.WriteLine($"Third digit is {user_num}");
      
    }
}

Console.WriteLine("Input number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

TDig(user_num);
*/



//-----------------------------------------------------------------------------------------------------------------------------------
/*
// Задача 15 На входе номер дня недели от 1 до 7 - на выходе 6,7 - Да, а 1-6 Нет

Console.WriteLine("Task 15");
void WeekendFinder(int user_number)
{
  if (user_number > 5 && user_number <= 7)
     {
      Console.WriteLine("Yes!, this is Weekend now");
     }
  else
     {
      Console.WriteLine("No, this is not Weekend..");
     }
}

Console.WriteLine("Enter number of the day from 1 to 7: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if  (user_number > 7 || user_number < 1)
     {
      Console.WriteLine("No!, there are 7 days in a week");
     }
     else
     {
     WeekendFinder(user_number);
     }
*/



//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++