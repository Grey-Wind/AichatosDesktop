using System.Net;

namespace CheckGetUrlPage
{
    public class Check
    {
        public static async Task<bool> CheckPageAsync()
        {
            using HttpClient client = new();
            HttpResponseMessage response = await client.GetAsync("https://x.aichatos8.com/");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
