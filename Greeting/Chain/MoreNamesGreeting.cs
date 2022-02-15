using Greeting.Extensions;
using System.Text;

namespace Greeting.Chain
{
    public class MoreNamesGreeting : AbstractGreeting
    {
        public override string Handle(params string[] names) => (Next == null) ? CreateString(names) : Next.Handle(names);

        private static string CreateString(string[] names)
        {
            names = names.Validate();
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            for (int i = 0; i < names.Length; i++)
            {
                if (i == names.Length - 1)
                    sb.Append($" and {names[i]}.");
                else
                    sb.Append($", {names[i]}");
            }
            return sb.ToString();
        }
    }
}
