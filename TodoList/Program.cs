using System.Threading.Channels;

char input;
bool running = true;

void PrintSelected(string option)
{
    Console.WriteLine("Selected option: " + option);
}
void SeeTodo()
{
    PrintSelected("See all TODOs");
}

void AddTodo()
{
    PrintSelected("Add a TODO");
}

void RemoveTodo()
{
    PrintSelected("Remove a TODO");
}

while (running)
{
    Console.WriteLine("Hello!\nWhat do you want to do?\n[S]ee all TODOs\n[A]dd a TODO\n[R]emove a todo\n[E]xit");
    input = char.ToUpper(Console.ReadKey().KeyChar);
    switch (input)
    {
        case 'S':
            SeeTodo();
            break;
        case 'A':
            AddTodo();
            break;
        case 'R':
            RemoveTodo();
            break;
        case 'E':
            running = false;
            break;
        default:
            Console.WriteLine(input + "is an invalid input.");
            break;
    }
}
Console.WriteLine("TODO list closed. Have a nice day.\nPress any key to exit.");
Console.ReadKey();
