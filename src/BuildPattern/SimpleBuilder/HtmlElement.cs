using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPattern
{
    public class HtmlElement
    {
        public string Name;
        public string Text;
        public List<HtmlElement> Elements = new List<HtmlElement>();
        private const int indentSize = 2;

        public HtmlElement() { }
        public HtmlElement(string name, string text)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Text = text ?? throw new ArgumentNullException(nameof(text));
        }

        private string ToStringImpl(int indent)
        {
            var sBuilder = new StringBuilder();
            var i = new string(' ', indentSize * indent);
            sBuilder.AppendLine($"{i}<{Name}>");
            if (!string.IsNullOrWhiteSpace(Text))
            {
                sBuilder.Append(' ', indentSize * (indent + 1));
                sBuilder.AppendLine(Text);
            }
            foreach (var e in Elements)
            {
                sBuilder.Append(e.ToStringImpl(indent + 1));
            }
            sBuilder.AppendLine($"{i}</{Name}>");

            return sBuilder.ToString();
        }
        public override string ToString()
        {
            return ToStringImpl(0);
        }
    }
}
