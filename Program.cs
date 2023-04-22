/*
//-------------------------------------------------------------------------------------------------------
//  ДЗ №1 Знакомство с C#  Станислав +7(925)-906-62-66 ***  GitHub https://github.com/StChak/Noris.git
//  Задача 2
Console.WriteLine("Task 2 "); // Two numbers at Input - compare and Output, which is max and which is min
Console.Write ("Input your 1st number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input your 2nd number b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a - b == 0)
  Console.Write ("Your enter equal numbers, let's try again!");
else
if (a - b > 0)
  Console.Write ($"max = {a}; min = {b}");
else
  Console.Write ($"max = {b}; min = {a}");
  */




//---------------------------------------------------------------------------------------------------------------------
//  Задача 4
/*
Console.WriteLine("Task 4 "); // Three numbers at Input - compare and Output, which is max

Console.Write ("Input your 1st number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input your 2nd number b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write ("Input your 3rd number c: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a == b & b == c) 
  Console.WriteLine ($"All numbers are equal {max}. Try again input different numbers");

if (b > max) max = b;
if (c > max) max = c;

  Console.WriteLine (max);
  */




//--------------------------------------------------------------------------------------------------------------------

// Задача 6 Even ore Not Even?
/*
Console.WriteLine("Task 6 ");
Console.Write ("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num % 2) == 0)
  Console.Write ($"Your number: {num} is Even");
else
  Console.Write ($"Your number: {num} is Not Even");
*/



//-------------------------------------------------------------------------------------------------------------------
/*
//  Задача 8 Input N - Output all Even from 1 -> N. (Цикл cur_N == 1)
//  Variant 1 increasing even sequence (as in the task)

Console.WriteLine("Task 8_1 ");
Console.Write ("Input your number N: ");
int numb_N = Convert.ToInt32(Console.ReadLine());

int current = 2;
while (current <= numb_N)
{
  if ((current % 2) == 0)
  Console.Write (current +" ");
  current ++;
}
*/

//********************************************************************
//  Variant 2 decreasing even sequence
/*
Console.WriteLine("Task 8_2 ");
Console.Write ("Input your number N: ");
int numb_N = Convert.ToInt32(Console.ReadLine());

int current = numb_N;
while (current >= 1)
{
  if ((current % 2) == 0)
  Console.Write (current +" ");
  current --;
}
*/
//________________________________________________________________________________________________________________________