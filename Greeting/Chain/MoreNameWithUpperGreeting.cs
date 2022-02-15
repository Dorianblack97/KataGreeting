﻿using Greeting.Extensions;
using System.Linq;
using System.Text;

namespace Greeting.Chain
{
    public class MoreNameWithUpperGreeting : AbstractGreeting
    {
        public override string Handle(params string[] names)
        {
            if (names.Any(x => x.IsUpper()))
            {
                return CreateString(names);
            }            
            return Next.Handle(names);
        }

        private static string CreateString(string[] names)
        {
            var lowerArray = names.Validate().MoveUpperToNewArray(out var upperArray);
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            for (int i = 0; i < lowerArray.Length; i++)
            {
                if (i == lowerArray.Length - 1)
                    sb.Append($" and {lowerArray[i]}.");
                else
                    sb.Append($", {lowerArray[i]}");
            }
            sb.Append(" AND HELLO");
            for (int i = 0; i < upperArray.Length; i++)
            {
                if (i == upperArray.Length - 1)
                    sb.Append($" {upperArray[i]}!");
                else
                    sb.Append($" {upperArray[i]},");
            }
            return sb.ToString();
        }
    }
}