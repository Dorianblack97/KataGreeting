using System;
using System.Collections.Generic;
using System.Linq;

namespace Greeting.Extensions
{
    public static class ValidateArray
    {

        public static string[] Validate2(this string[] names)
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

        public static string[] Validate(this string[] names)
        {
            var namesList = names.SelectMany(x => (Test(x)));
            return namesList.ToArray();
        }

        private static IEnumerable<string> Test(string input)
        {
            if (input.Contains("\""))
            {
                return new String[] { input.Trim('"') };
            }
            else return input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
        }

    }




}
