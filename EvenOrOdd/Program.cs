Console.WriteLine("Even or Odd");
Console.Write("Enter an integer: ");
var answer = Console.ReadLine();
var input = Convert.ToInt32(answer);

while(input != 0)
{
    if (input % 2 == 0)
    {
        Console.WriteLine(answer + " is even");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine(answer + " is odd");
        Console.WriteLine();
    }

    Console.Write("Enter an integer: ");
    answer = Console.ReadLine();
    input = Convert.ToInt32(answer);
}

Console.WriteLine("Done...");