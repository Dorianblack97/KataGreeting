using Greeting.Chain;

namespace Greeting
{
    public class Greeting : IGreeting
    {
        public string Greet(params string[] name)
        {
            var nullGreeter = new NullNameGreeting();
            var oneNameGreeter = new OneNameGreeting();
            nullGreeter.SetNext(oneNameGreeter);
            var manyUpperNameGreeter = new MoreNameWithUpperGreeting();
            oneNameGreeter.SetNext(manyUpperNameGreeter);
            var manyNameGreeter = new MoreNamesGreeting();
            manyUpperNameGreeter.SetNext(manyNameGreeter);
            return nullGreeter.Handle(name);
            }
        }
    }
