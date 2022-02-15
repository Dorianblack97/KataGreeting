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
                        var tempString = item.Remove(0, 1);
                        tempString = tempString.Remove(tempString.Length - 1);
                        namesList.Add(tempString);
                        break;
                    case true:
                        var tempArray = item.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                        tempArray.ToList().ForEach(x => namesList.Add(x));
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
