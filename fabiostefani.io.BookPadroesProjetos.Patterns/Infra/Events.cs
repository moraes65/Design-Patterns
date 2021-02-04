using System.Collections.Generic;
using System.Text;

namespace fabiostefani.io.BookPadroesProjetos.Patterns.Infra
{
    public static class Events
    {
        public static readonly List<string> Event = new List<string>();

        public static void Add(string message)
        {
            Event.Add(message);
        }

        public static void Clear()
        {
            Event.Clear();
        }

        public static string Print()
        {
            var str = new StringBuilder();
            Event.ForEach(x => str.AppendLine(x));
            return str.ToString();
        }
    }
}
