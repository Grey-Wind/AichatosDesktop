if (args.Length == 0)
{
    return;
}

string command = args[0];

switch (command)
{
    case "greet":
        Greet();
        break;
    case "time":
        ShowTime();
        break;
    case "date":
        ShowDate();
        break;
    case "exit":
        Exit();
        break;
    default:
        Console.WriteLine("Unknown command. Available commands: greet, time, date, exit.");
        break;
}
