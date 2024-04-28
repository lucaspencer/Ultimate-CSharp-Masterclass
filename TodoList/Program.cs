using Newtonsoft.Json;
using System.ComponentModel;
using System.Threading.Channels;


char input;
bool running = true;
Init();

while (running)
{
    Console.WriteLine("What do you want to do?\n[S]ee all TODOs\n[A]dd a TODO\n[R]emove a todo\n[E]xit");
    input = char.ToUpper(Console.ReadKey().KeyChar);
    switch (input)
    {
        case 'S':
            PrintSelected("See all TODOs");
            var todos = GetTodos();
            ListTodos(todos);
            break;
        case 'A':
            AddTodo();
            break;
        case 'R':
            RemoveTodo();
            break;
        case 'E':
            running = false;
            Console.WriteLine("TODO list closed. Have a nice day.\nPress any key to exit.");
            Console.ReadKey();
            break;
        default:
            Console.WriteLine($"\n{input} is an invalid input.\n");
            break;
    }
}


//methods defined here
void Init()
{

    if (!File.Exists("data.json"))
    {
        File.WriteAllText(@"data.json", "[]");
    }
}

List<string>? GetTodos()
{
    List<string>? deserializedData = JsonConvert.DeserializeObject<List<string>?>(File.ReadAllText(@"data.json"));
    return deserializedData;
}

void WriteFile(List<string> todos)
{
    string serializedData = JsonConvert.SerializeObject(todos);
    File.WriteAllText("data.json", serializedData);
}

void PrintSelected(string option) => Console.WriteLine("\nSelected option: " + option);

bool ListTodos(List<string>? todos)
{
    if (todos.Count == 0) { Console.WriteLine("No TODOs have been added yet."); return false; } 
    else
    {
        var i = 1;
        foreach (var entry in todos)
        {
            Console.WriteLine($"{i}: {entry}");
            i++;
        }
        return true;
    }
}

void AddTodo()
{
    PrintSelected("Add a TODO\n");
    var todos = GetTodos();
    var description = "";
    var looping = true;
    while (looping)
    {
        description = Console.ReadLine();
        if (description.Trim() == "") { Console.WriteLine("The description cannot be empty."); continue; }
        if (todos.Contains(description)) { Console.WriteLine("The description must be unique."); continue; }
        looping = false;
    }

    todos.Add(description);
    WriteFile(todos);
    Console.WriteLine($"TODO successfully added: {description}");
}

void RemoveTodo()
{
    PrintSelected("Remove a TODO");
    var todos = GetTodos();
    while (true)
    {
        Console.WriteLine("Select the index of the TODO you want to remove:");
        if (!ListTodos(todos))
        {
            return;
        }
        var input = Console.ReadLine();
        if (input == null || input == "") { Console.WriteLine("Selected index cannot be empty."); continue; }
        var parsed = int.TryParse(input, out int index);
        if (!parsed || index > todos.Count || index < 1) { Console.WriteLine("The given index is not valid."); continue; }
        index--;
        string description = todos[index];
        todos.RemoveAt(index);
        WriteFile(todos);
        Console.WriteLine($"TODO removed: {description}");
        return;
    }
}
