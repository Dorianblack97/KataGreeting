using Greeting.Chain;

namespace Greeting
{
    public class Greeting : IGreeting
    {
        private IGreetingHandler nullGreeter,
                                 oneNameUpperGreeter,
                                 oneNameGreeter,
                                 manyUpperNameGreeter,
                                 manyNameGreeter;
        public Greeting()
        {
            nullGreeter = new NullNameGreeting();
            oneNameUpperGreeter = new OneNameUpperGreeting();
            nullGreeter.SetNext(oneNameUpperGreeter);
            oneNameGreeter = new OneNameGreeting();
            oneNameUpperGreeter.SetNext(oneNameGreeter);
            manyUpperNameGreeter = new MoreNameWithUpperGreeting();
            oneNameGreeter.SetNext(manyUpperNameGreeter);
            manyNameGreeter = new MoreNamesGreeting();
            manyUpperNameGreeter.SetNext(manyNameGreeter);
        }
        public string Greet(params string[] name) => nullGreeter.Handle(name);
    }
}
