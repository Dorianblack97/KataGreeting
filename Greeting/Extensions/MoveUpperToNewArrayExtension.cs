using System.Collections.Generic;

namespace Greeting.Extensions
{
    public static class MoveUpperToNewArrayExtension
    {
        public static string[] MoveUpperToNewArray(this string[] nameArray, out string[] UpperArray)
        {
            var UpperList = new List<string>();
            var LowerList = new List<string>();
            foreach (var item in nameArray)
            {
                if (item.IsUpper())
                    UpperList.Add(item);
                else
                    LowerList.Add(item); ;
            }
            UpperArray = UpperList.ToArray();
            return LowerList.ToArray();
        }
    }
}
