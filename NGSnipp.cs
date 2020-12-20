using System;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

class NGExample
{
	private static void NGSnippet()
			{
				var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.newgrounds.io/gateway_v3.php");
				httpWebRequest.ContentType = "application/json";
				httpWebRequest.Method = "POST";

				using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
				{
					string JsonCall = File.ReadAllText(@"C:\Users\Alex\source\repos\PortalClub\conn.json");
					streamWriter.Write(JsonCall);
				}

				var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
				{
					var result = streamReader.ReadToEnd();
					Console.WriteLine(result);
				}
				
			}
}