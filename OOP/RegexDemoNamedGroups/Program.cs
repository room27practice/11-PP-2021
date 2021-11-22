using HtmlAgilityPack;
using System.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace RegexDemoNamedGroups
{
    class Program
    {
        private static string destinationPath = "../../../result.txt";
        private static string pattern = @"<div\s+class=""anecdote-text""\s*>\s*<p>[\r\s]*(?<Vic>[^<]+)\r?";
        private static string[] cathegories = { "geroi-ot-prikazkite-182", "advokati-lekari-13" };

        private static string urlFormat = "https://www.vesti.bg/vicove/{0}/{1}";

        static void Main()
        {
            HtmlWeb web = new HtmlWeb();
            List<string> jokes = new List<string>();
            foreach (string cath in cathegories)
            {
                int pageCounter = 0;
                while (true)
                {
                    pageCounter++;
                    HtmlDocument htmlDoc = web.Load(string.Format(urlFormat, cath, pageCounter));
                    var htmlText = htmlDoc.ParsedText;
                    if (!HasJokesOnThatPage(htmlText))
                    {
                        break;
                    }

                    MatchCollection matches = Regex.Matches(htmlText, pattern);
                    foreach (Match match in matches)
                    {
                        jokes.Add(match.Groups["Vic"].Value.Trim());
                    }
                }
            }
            Console.WriteLine("Jokes Downloaded: "+jokes.Count());
            File.WriteAllText(destinationPath, string.Join(Environment.NewLine + new string('=', 70) + Environment.NewLine, jokes));
        }

        private static bool HasJokesOnThatPage(string content)
        {
            return content.Contains("<!-- Вицове, списък -->");
        }
    }
}
