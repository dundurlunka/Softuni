using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        private List<string> numbers;
        private List<string> urls;

        public Smartphone()
        {
            this.Numbers = new List<string>();
            this.Urls = new List<string>();
        }

        public List<string> Numbers { get => numbers; set => numbers = value; }
        public List<string> Urls { get => urls; set => urls = value; }

        public string Browse(string url)
        {
            var doesDigitOccur = url.Any(c => char.IsDigit(c));
            if (doesDigitOccur)
            {
                return "Invalid URL!";
            }
            return $"Browsing: {url}";
        }

        public string Call(string number)
        {
            var isValid = number.All(c => char.IsDigit(c));
            if (!isValid)
            {
                return "Invalid number!";
            }
            return $"Calling... {number}";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var number in this.Numbers)
            {
               sb.AppendLine(this.Call(number));
            }
            foreach (var url in this.Urls)
            {
                sb.AppendLine(this.Browse(url));
            }
            return sb.ToString().Trim();
        }
    }
}
