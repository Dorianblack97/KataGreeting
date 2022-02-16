using Greeting.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting.Chain
{
    public class OneNameUpperGreeting : AbstractGreeting
    {
        public override string Handle(params string[] names) => names.Length==1 && names[0].IsUpper() ? $"HELLO, {names[0]}!" : Next.Handle(names);
        
    }
}
