
int GetNumber()
{
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Invalid input. Please try again.\n");
    }
    return num;
}

void GetOperation(int num1, int num2)
{
    bool loop = true;
    char input;
    while (loop)
    {
        input = char.ToUpper(Console.ReadKey().KeyChar);
        
        switch (input)
        {
            case 'A':
                Console.WriteLine($"\n{num1} + {num2} = {num1 + num2}");
                loop = false;
                break;
            case 'S':
                Console.WriteLine($"\n{num1} - {num2} = {num1 - num2}");
                loop = false;
                break;
            case 'M':
                Console.WriteLine($"\n{num1} ÷ {num2} = {num1 / num2}");
                loop = false;
                break;
            default:
                Console.WriteLine("\nInvalid input. Please try again.\n");
                break;   
        }
    }
}

Console.WriteLine("Hello!\nInput the first number:");
int num1 = GetNumber();
Console.WriteLine("Input the second number:");
int num2 = GetNumber();
Console.WriteLine("What do you want to do with those numbers?\n[A]dd\n[S]ubtract\n[M]ultiply");
GetOperation(num1, num2);
Console.WriteLine("Press any key to close");
Console.ReadLine();
