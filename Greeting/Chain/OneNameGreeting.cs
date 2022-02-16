using Greeting.Extensions;

namespace Greeting.Chain
{
    public class OneNameGreeting : AbstractGreeting
    {
        public override string Handle(params string[] names) => names.Length == 1 ? $"Hello, {names[0]}." : Next.Handle(names);        
    }
}
