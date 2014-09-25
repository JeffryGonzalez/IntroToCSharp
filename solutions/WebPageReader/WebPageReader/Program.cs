using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WebPageReader
{
	class Program
	{
		static void Main(string[] args)
		{
			Uri uri = null;
			if (args.Length == 0)
			{
				Console.Write("Enter a URL: ");
				uri = new Uri(Console.ReadLine());
			}
			else
			{
				uri = new Uri(args[0]);
			}

			var client = new HttpClient();
			var stopWatch = new Stopwatch();
			stopWatch.Start();
			var request = client.GetAsync(uri).Result;
			
			if (request.IsSuccessStatusCode)
			{
				var response = request.Content.ReadAsStringAsync().Result;
				stopWatch.Stop();
				var fileName = (uri.Host + uri.AbsolutePath).Replace('/', '_');
				Console.WriteLine("{0} took about {1} milliseconds to download", uri, stopWatch.ElapsedMilliseconds);
				string fullFileName = Path.Combine(@"c:\practices\", fileName);
				if (File.Exists(fullFileName))
				{
					File.Delete(fullFileName);
				}
				File.WriteAllText(fullFileName + ".html", response);
			}
			else
			{
				Console.WriteLine("Sorry - some error: {0}  ({1})",(int) request.StatusCode, request.ReasonPhrase);
			}
			client.Dispose();



		}
	}
}
