using GetLink;

Get get = new();

List<string> links = await get.GetLatestLinkAsync_Edge();

foreach (var link in links)
{
    Console.WriteLine(link);
}

