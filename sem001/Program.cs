//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input first number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 > number_2)
    Console.Write ("a = " + number_1 + ", b = "+ number_2 + " ->" + " a");
else 
    Console.WriteLine("a = " + number_1 + ", b = "+ number_2 + " -> "+ " b");   


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

