using Greeting.Chain;

namespace Greeting
{
    public class Greeting : IGreeting
    {
        private IGreetingHandler nullGreeter,
                                 oneNameGreeter,
                                 manyUpperNameGreeter,
                                 manyNameGreeter;
        public Greeting()
        {
            nullGreeter = new NullNameGreeting();
            oneNameGreeter = new OneNameGreeting();
            nullGreeter.SetNext(oneNameGreeter);
            manyUpperNameGreeter = new MoreNameWithUpperGreeting();
            oneNameGreeter.SetNext(manyUpperNameGreeter);
            manyNameGreeter = new MoreNamesGreeting();
            manyUpperNameGreeter.SetNext(manyNameGreeter);
        }
        public string Greet(params string[] name) => nullGreeter.Handle(name);
    }
}
