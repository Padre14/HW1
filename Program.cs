// Задача 2: Напишите программу, которая на вход принимает
// два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine("Task 2");
Console.WriteLine("Enter numbers1 :");
string strNumber1 = Console.ReadLine();
Console.WriteLine("Enter numbers2 :");
string strNumber2 = Console.ReadLine();

int number1 = Convert.ToInt32(strNumber1);
int number2 = Convert.ToInt32(strNumber2);
if(number1>number2)
{
    Console.WriteLine("maximum = "+ number1);
    Console.WriteLine("minimum = "+ number2);
}
else
{
    Console.WriteLine("maximum = "+ number2);
    Console.WriteLine("minimum = "+ number1);
}


// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.

Console.WriteLine("Task 4");
Console.WriteLine("Enter numbers1 :");
string strNumA = Console.ReadLine();
Console.WriteLine("Enter numbers2 :");
string strNumB = Console.ReadLine();
Console.WriteLine("Enter numbers3 :");
string strNumC = Console.ReadLine();

int numA = Convert.ToInt32(strNumA);
int numB = Convert.ToInt32(strNumB);
int numC = Convert.ToInt32(strNumC);

int max = numA;

if (numA>max) max = numA;
if (numB>max) max = numB;
if (numC>max) max = numC;

Console.Write("max=");
Console.WriteLine(max);

// Задача 6: Напишите программу, которая на вход принимает
// число и выдает, является ли число четным (делится ли оно на
// два без остатка).

Console.WriteLine("Task 6");
Console.WriteLine("Enter numbers :");
string strA = Console.ReadLine();

int a = Convert.ToInt32(strA);

if (a%2==0) 
{
   Console.WriteLine("число четное");
}
else
{
   Console.WriteLine("число не четное"); 
}

// Задача 8: Напишите программу, которая на вход принимает
// число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Enter numbers :");
string strN = Console.ReadLine();

int N = Convert.ToInt32(strN);

int num = 2;

if (N==1 || N<=0)
{ 
    Console.WriteLine("введите число больше 1");
}
else
{
    while (num<=N)
    {
        Console.Write(num);
        num = num + 2;
    }
}

