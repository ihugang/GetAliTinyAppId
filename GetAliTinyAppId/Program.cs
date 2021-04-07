using System;
using System.Net;
using System.Text;

namespace GetAliTinyAppId
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length==0)
            {
                Console.WriteLine("Example: GetAliTinyAppId https://ur.alipay.com/2quabM");
                return;
            }
            else
            {
                var urls = GetAliTinyAppId.Program.RedirectPath(args[0]);
                Console.WriteLine(urls);
            }
        }

        public static string RedirectPath(string url)
        {
            StringBuilder sb = new StringBuilder();
            string location = string.Copy(url);
            while (!string.IsNullOrWhiteSpace(location))
            {
                sb.AppendLine(location); // you can also use 'Append'
                HttpWebRequest request = HttpWebRequest.CreateHttp(location);
                request.AllowAutoRedirect = false;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    location = response.GetResponseHeader("Location");
                    if (location.Contains("%3D") && location.Contains("%26"))
                    {
                        var leftIndex = location.IndexOf("%3D");
                        var rightIndex = location.IndexOf("%26");
                        var appId = location.Substring(leftIndex + 3, rightIndex - leftIndex - 3);
                        Console.WriteLine($"AppId:{appId}");
                    }
                }
            }
            return sb.ToString();
        }
    }
}
