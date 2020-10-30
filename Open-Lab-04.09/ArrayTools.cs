using System;
using System.Collections.Generic;

namespace Open_Lab_04._09
{
    public class ArrayTools
    {
        public string[] RemoveDups(string[] strings)
        {
            List<string> lists = new List<string>();
            foreach (string str in strings)
            {
                if (!lists.Contains(str))
                {
                    lists.Add(str);
                }
            }

            return lists.ToArray();
        }
    }
}
