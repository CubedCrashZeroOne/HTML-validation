using System.Collections.Generic;

namespace HtmlFiles
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<Person>()
            {
                new Person("Oleg", "crashcube001@gmail.com"),
                new Person("Margarita", "margarit@gmail.com"),
                new Person("Dmitriy", "chelovek1@mail.ru"),
                new Person("Vadim", "cin@gmail.com"),
                new Person("Ventzeslav", "ventztawit@gmail.com"),
                new Person("Maxim<script>alert('Name!')</script>", "maxjs@gmail.com")
            };
            
            HtmlWriter.GenerateHtml(list);
            
        }
    }
}