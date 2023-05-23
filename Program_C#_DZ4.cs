// Чаков С. В. https://github.com/StChak/Noris.git
//-------------------------------------------------------1-----------------------------------------------------------------------
// Семинар 4. Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.(Без MathPow)
/*
void RaisNumPow()
{
Console.WriteLine("Input your number A: ");
int userA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your number B power: ");
int userB = Convert.ToInt32(Console.ReadLine());

  int powA = 1;
  for (int cur = 1; cur <= userB; cur++)
  {
   powA *= userA;
  }
 Console.WriteLine($"The power of number A is: {powA}");
}

RaisNumPow();
*/
//-------------------------------------------------------2--------------------------------------------------------------------------------------
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
void sumNumDigs()
{
    Console.WriteLine("Input your number: ");
    int userN = Convert.ToInt32(Console.ReadLine());
    if(userN < 0)
      {
        userN *= -1;
      }
    int sumDig = 0;
    int lastN;
    for(lastN = 0; userN > 9; userN /= 10)
      {
       lastN += userN %10;
      }
        sumDig = lastN + userN;
        Console.WriteLine($"The sum of the digits is: {sumDig}");
}

sumNumDigs();
//--------------------------------------------------------3-------------------------------------------------------------------
*/
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
/*
int [] array = { 6, 9, 3, 1, 2, 4, 8, 7 };
void ShowArrayElement()
{
    string result = "[";
    for (int i = 0; i < array.Length; i++) 
    { 
        result += array[i];
        if (i != array.Length - 1)
        {
                result += ", ";
        }
        if(i == array.Length - 1)
        {
            result += "]";
        }
    }
    Console.WriteLine(result);
}

ShowArrayElement();
*/
// [6, 9, 3, 1, 2, 4, 8, 7]
//********************************************************************************************************************************