using Greeting.Extensions;

namespace Greeting.Chain
{
    public class OneNameGreeting : AbstractGreeting
    {
        public override string Handle(params string[] names)
        {
            if (names[0].IsUpper())
                return $"HELLO, {names[0]}!";
            if (names.Length == 1)
                return $"Hello, {names[0]}.";
            return Next.Handle(names);
        }
    }
}
