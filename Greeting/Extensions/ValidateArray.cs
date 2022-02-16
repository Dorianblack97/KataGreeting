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
                if (item.Contains("\""))
                {
                    namesList.Add(item.Trim('"'));
                }
                else namesList.AddRange(item.Split(",", StringSplitOptions.RemoveEmptyEntries));
            }

            return namesList.Select(x => x.Trim()).ToArray();
        }

    }




}
