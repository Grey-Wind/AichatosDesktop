internal class Program
{
    private static readonly string relativePath = "o";

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
        Get get = new();

        if (await CheckPageAsync())
        {
            List<string> links = null!;

            if (IsChromeInstalled())
            {
                links = await get.GetLatestLinkAsync_Chrome();
            }
            else if (IsEdgeInstalled())
            {
                links = await get.GetLatestLinkAsync_Edge();
            }
            else if (IsFirefoxInstalled())
            {
                links = await get.GetLatestLinkAsync_Firefox();
            }
            else if (IsSafariInstalled())
            {
                links = await get.GetLatestLinkAsync_Safari();
            }
            else if (IsIEInstalled())
            {
                links = await get.GetLatestLinkAsync_InternetExplorer();
            }
            else
            {
                WriteContent("BrowserNotFound");
                return;
            }

            if (links != null)
            {
                Write(links);
            }
            else
            {
                WriteContent("NoLinksFound");
            }
        }
        else
        {
            WriteContent("CheckUrlError");
        }
    }

    /// <summary>
    /// 向 o 内写入内容
    /// </summary>
    /// <param name="content"></param>
    private static void WriteContent(string content)
    {
        // using StreamWriter writer = new(relativePath);
        // writer.WriteLine(content);

        // 清空文件内容并写入新内容
        File.WriteAllText(relativePath, content);
    }

    private static void Write(List<string> links)
    {
        if (links != null)
        {
            foreach (var link in links)
            {
                WriteContent(link);
            }
        }
        else
        {
            WriteContent("link-null");
        }
    }
}