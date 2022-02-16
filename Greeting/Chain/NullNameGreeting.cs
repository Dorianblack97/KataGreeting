namespace Greeting.Chain
{
    public class NullNameGreeting : AbstractGreeting
    {
        public override string Handle(params string[] names) => names == null ? "Hello, my friend." : Next.Handle(names);
        
    }
}
