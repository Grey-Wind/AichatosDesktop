using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;

namespace GetLink
{
    public class Get
    {
        /// <summary>
        /// 等待页面加载完成的时间，默认250毫秒（0.25秒）
        /// </summary>
        public int WaitPageLoadTime { get; set; } = 250;

        public async Task<List<string>> GetLatestLinkAsync_Chrome()
        {
            string url = "https://x.aichatos8.com/";

            var links = new List<string>();

            // 设置Chrome选项
            var options = new ChromeOptions();

            // 隐藏浏览器窗口
            options.AddArgument("--headless");

            // 禁止输出日志到控制台
            options.AddArgument("--disable-logging");
            options.AddArgument("--log-level=3");

            using (var driver = new ChromeDriver(options))
            {
                // 打开页面
                driver.Navigate().GoToUrl(url);

                // 等待页面加载完成
                await Task.Delay(WaitPageLoadTime);

                // 查找所有class为address的div标签中的a标签的href属性
                var addressDivs = driver.FindElements(By.XPath("//div[contains(@class, 'address')]/a[@href]"));

                foreach (var div in addressDivs)
                {
                    var href = div.GetAttribute("href");
                    links.Add(href);
                }
            }

            return links;
        }

        public async Task<List<string>> GetLatestLinkAsync_Edge()
        {
            string url = "https://x.aichatos8.com/";

            var links = new List<string>();

            // 设置Edge选项
            var options = new EdgeOptions();

            // 隐藏浏览器窗口
            options.AddArgument("--headless");

            // 禁止输出日志到控制台
            options.AddArgument("--disable-logging");
            options.AddArgument("--log-level=3");

            using (var driver = new EdgeDriver(options))
            {
                // 打开页面
                driver.Navigate().GoToUrl(url);

                // 等待页面加载完成
                await Task.Delay(WaitPageLoadTime);

                // 查找所有class为address的div标签中的a标签的href属性
                var addressDivs = driver.FindElements(By.XPath("//div[contains(@class, 'address')]/a[@href]"));

                foreach (var div in addressDivs)
                {
                    var href = div.GetAttribute("href");
                    links.Add(href);
                }
            }

            return links;
        }

        public async Task<List<string>> GetLatestLinkAsync_Firefox()
        {
            string url = "https://x.aichatos8.com/";

            var links = new List<string>();

            // 设置Firefox选项
            var options = new FirefoxOptions();

            // 隐藏浏览器窗口
            options.AddArgument("--headless");

            // 禁止输出日志到控制台
            options.AddArgument("--disable-logging");
            options.AddArgument("--log-level=3");

            using (var driver = new FirefoxDriver(options))
            {
                // 打开页面
                driver.Navigate().GoToUrl(url);

                // 等待页面加载完成
                await Task.Delay(WaitPageLoadTime);

                // 查找所有class为address的div标签中的a标签的href属性
                var addressDivs = driver.FindElements(By.XPath("//div[contains(@class, 'address')]/a[@href]"));

                foreach (var div in addressDivs)
                {
                    var href = div.GetAttribute("href");
                    links.Add(href);
                }
            }

            return links;
        }

        public async Task<List<string>> GetLatestLinkAsync_Safari()
        {
            string url = "https://x.aichatos8.com/";

            var links = new List<string>();

            // 设置Safari选项
            var options = new SafariOptions();

            // 设置 Safari 选项
            options.EnableAutomaticInspection = false;
            options.EnableAutomaticProfiling = false;

            using (var driver = new SafariDriver(options))
            {
                // 打开页面
                driver.Navigate().GoToUrl(url);

                // 等待页面加载完成
                await Task.Delay(WaitPageLoadTime);

                // 查找所有class为address的div标签中的a标签的href属性
                var addressDivs = driver.FindElements(By.XPath("//div[contains(@class, 'address')]/a[@href]"));

                foreach (var div in addressDivs)
                {
                    var href = div.GetAttribute("href");
                    links.Add(href);
                }
            }

            return links;
        }

        public async Task<List<string>> GetLatestLinkAsync_InternetExplorer()
        {
            string url = "https://x.aichatos8.com/";

            var links = new List<string>();

            // 设置 IE 选项
            var options = new InternetExplorerOptions();

            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true; // 通过忽略保护模式设置引入不稳定性

            options.IgnoreZoomLevel = true; // 忽略缩放级别
            options.EnsureCleanSession = true; // 确保会话干净
            options.BrowserCommandLineArguments = "-private"; // 浏览器命令行参数，设置私密

            using (var driver = new InternetExplorerDriver(options))
            {
                // 打开页面
                driver.Navigate().GoToUrl(url);

                // 等待页面加载完成
                await Task.Delay(WaitPageLoadTime);

                // 查找所有class为address的div标签中的a标签的href属性
                var addressDivs = driver.FindElements(By.XPath("//div[contains(@class, 'address')]/a[@href]"));

                foreach (var div in addressDivs)
                {
                    var href = div.GetAttribute("href");
                    links.Add(href);
                }
            }

            return links;
        }
    }
}
