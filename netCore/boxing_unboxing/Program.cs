using System;
using System.Collections.Generic;

namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> values = new List<object>();
            values.Add(7);
            values.Add(-1);
            values.Add(28);
            values.Add(true);
            values.Add("chair");
            int sum = 0;
            foreach(object obj in values)
            {
                System.Console.WriteLine(obj);
                if (obj is int)
                {
                    sum += Convert.ToInt32(obj);
                }
            }
            System.Console.WriteLine(sum);
        }
    }
}
