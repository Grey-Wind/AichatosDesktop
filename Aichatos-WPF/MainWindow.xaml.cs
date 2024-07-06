using System.IO;
using System.Windows;

namespace Aichatos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += WhenStart;
        }

        private async void WhenStart(object sender, RoutedEventArgs e)
        {
            webBrowser.Source = ToUri(await GetUrlAsync());
            webBrowser.Refresh();
        }

        private static Uri ToUri(List<string> links)
        {
            string link = links[0];
            WriteContent(link);
            Uri uri = new(link);
            return uri;
        }

        private static async Task<List<string>> GetUrlAsync()
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
                    throw new Exception("BrowserNotFound");
                }

                if (links != null)
                {
                    return links;
                }
                else
                {
                    throw new Exception("NoLinksFound");
                }
            }
            else
            {
                throw new Exception("CheckUrlError");
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
            File.WriteAllText(".txt", content);
        }
    }
}