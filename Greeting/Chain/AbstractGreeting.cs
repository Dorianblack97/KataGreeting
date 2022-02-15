using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting.Chain
{
    public abstract class AbstractGreeting : IGreetingHandler
    {
        protected IGreetingHandler Next;
        public abstract string Handle(params string[] names);
       

        public IGreetingHandler SetNext(IGreetingHandler greetingHandler)
        {
            Next = greetingHandler;
            return this;
        }
    }
}
