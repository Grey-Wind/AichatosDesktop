internal class Program
{
    private static async Task Main(string[] args)
    {
        if (args.Length == 0)
        {
            return;
        }

        string command = args[0];

        switch (command)
        {
            case "--get-url":
                await GetUrlAsync();
                break;
            case "--help":
                ShowHelpInfo();
                break;
            case "--install":
                Install();
                break;
            default:
                break;
        }
    }

    private static void Install()
    {
        Console.WriteLine("You cannot use this.");
    }

    private static void ShowHelpInfo()
    {
        Console.WriteLine("Guess where is the true info.");
    }

    private static async Task GetUrlAsync()
    {
        if(await CheckPageAsync() == true)
        {
            return;
        }
        else
        {
            return;
        }
    }
}