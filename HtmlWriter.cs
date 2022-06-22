using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace HtmlFiles
{
    internal static class HtmlWriter
    {
        private static readonly string WorkingDirectory = Directory.GetCurrentDirectory();
        
        public static void GenerateHtml(List<Person> list)
        {
            var finalText = new StringBuilder("<body>" + Environment.NewLine);

            for (int i = 0; i < list.Count; ++i)
            {
                var name = new StringBuilder(list[i].Name);
                var email = new StringBuilder(list[i].Email);

                name.Replace("&", "&amp;")
                    .Replace("\"", "&quot;")
                    .Replace("'", "&apos;")
                    .Replace("<", "&lt;")
                    .Replace(">", "&gt;");
                
                email.Replace("&", "&amp;")
                     .Replace("\"", "&quot;")
                     .Replace("'", "&apos;")
                     .Replace("<", "&lt;")
                     .Replace(">", "&gt;");
                
                // Didn't use interpolation because I wrote this in C# 5.0 
                finalText.Append("<a href=\"mailto:"+email+"\">"+name+"</a>");

                if (i != list.Count - 1)
                {
                    finalText.Append(" |" + Environment.NewLine);
                }

            }

            finalText.Append(Environment.NewLine + "</body>");
            
            using (var file = new StreamWriter(WorkingDirectory + @"\index.html", false))
            {
                file.Write(finalText);
            }
        }
    }
}