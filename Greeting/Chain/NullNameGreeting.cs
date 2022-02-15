namespace Greeting.Chain
{
    public class NullNameGreeting : AbstractGreeting
    {
        public override string Handle(params string[] names)
        {
            if (names == null)
                return "Hello, my friend.";
            return (Next == null) ? "Hello, my friend." : Next.Handle(names);
        }
    }
}
