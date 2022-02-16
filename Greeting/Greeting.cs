using Greeting.Chain;

namespace Greeting
{
    public class Greeting : IGreeting
    {
        private IGreetingHandler _handler;
        public Greeting(IGreetingHandler handler)
        {
            _handler = handler;
        }
        public string Greet(params string[] name) => _handler.Handle(name);
    }
}
