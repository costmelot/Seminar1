//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
 
if (num1 > num2)
{
Console.WriteLine($"max = {num1}");
}
else if (num1 < num2)
{
Console.WriteLine($"max = {num2}");
}
else
{
Console.WriteLine($"max = {num1}");
}

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
 
Console.WriteLine("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)

    Console.WriteLine(a); 
    
else if (b > a && a > c)  

    Console.WriteLine(b); 

else

    Console.WriteLine(c);


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
                  
Console.WriteLine("введите число: ");
int z = Convert.ToInt32(Console.ReadLine()); 
 
if (z % 2 == 0)
{
Console.WriteLine("да");
           
}
else
{
Console.WriteLine("нет");
}
 
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());   
for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);