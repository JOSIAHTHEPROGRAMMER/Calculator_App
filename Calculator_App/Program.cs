// See https://aka.ms/new-console-template for more information



using System;

Console.WriteLine("Hello, Lets calculate!!");
bool keepRunning = true;

string? user;

while (keepRunning)
{
    Console.WriteLine("What is the operation to be performed\n\nTypes:\n" +
        "X = multiplication\nA = addition\nS = subtraction\nD = division\nM = modulation\n");

    char? operation = Char.ToUpper(Convert.ToChar(Console.Read()));
    Console.ReadLine();


    Console.WriteLine("\nWhat is the value of x");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nWhat is the value of y");
    int num2 = Convert.ToInt32(Console.ReadLine());

    int result = 0;

    if (operation == 'A')
    {
        result = num1 + num2;
    }
    else if (operation == 'X')
    {
        result = num1 * num2;
    }
    else if (operation == 'S')
    {
        result = num1 - num2;
    }
    else if (operation == 'D')
    {
        result = num1 / num2;
    }
    else if (operation == 'M')
    {
        result = num1 % num2;
    }

    Console.WriteLine("\nThe result is " + result);

    Console.WriteLine("\nDo you wish to continue calculation stuff?? (Y / N )");
    user = Console.ReadLine();

    if (!string.Equals(user, "Y", StringComparison.OrdinalIgnoreCase) &&
      !string.Equals(user, "YES", StringComparison.OrdinalIgnoreCase))
    {
        keepRunning = false;
    }


}

Console.WriteLine("\nHave a nice day!");


Console.ReadKey();
