using System;
using System.Collections.Generic;
using System.Linq;

namespace Greeting.Extensions
{
    public static class ValidateArray
    {
        public static string[] Validate(this string[] names)
        {
            var namesList = new List<string>();
            foreach (var item in names)
            {
                switch (item.Contains(","))
                {
                    case true when item.Contains("\""):                                           
                        namesList.Add(item.Trim('"'));
                        break;
                    case true:
                        namesList.AddRange(item.Split(", ", StringSplitOptions.RemoveEmptyEntries));
                        break;
                    default:
                        namesList.Add(item);
                        break;
                }
            }
            return namesList.ToArray();
        }
    }
}