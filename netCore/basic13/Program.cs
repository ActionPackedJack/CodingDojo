using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            // for(int i=1; i < 256; i++)
            // {
            //     System.Console.WriteLine(i);
            // }
            // for(int i=1; i < 256; i += 2)
            // {
            //     System.Console.WriteLine(i);
            // }
            // int sum = 0;
            // for(int i=0; i < 256; i++)
            // {
            //     sum += i;
            //     System.Console.WriteLine(i.ToString() + " Sum: " + sum.ToString());
            // }
            int[]arr = {
                1,
                3,
                7,
                12,
                0,
                50,
                -18,
                576,
                12408,
                -10,
            };
            // for(int i=0; i<arr.Length; i++)
            // {
            //     System.Console.WriteLine(arr[i]);
            // }
            // int max= arr[0];
            // for(int i=1; i<arr.Length; i++)
            // {
            //     if(arr[i] > max)
            //     {
            //         max = arr[i];
            //     }
            // }
            // System.Console.WriteLine(max);
            // int greaterThan = 0;
            // int minimum = 17;
            // for(int i = 0; i < arr.Length; i++)
            // {
            //     if( arr[i] > minimum)
            //     {
            //         greaterThan ++;
            //     }
            // }
            // System.Console.WriteLine(greaterThan);
            // for(int i=0; i<arr.Length; i++)
            // {
            //     if(arr[i]<0)
            //     {
            //         arr[i]=0;
            //     }
            //     System.Console.WriteLine(arr[i]);
            // }
            // for(int i=0; i<arr.Length; i++)
            // {
            //     arr[i]*=arr[i];
            //     System.Console.WriteLine(arr[i]);
            // }
            // int max= arr[0];
            // int min= arr[0];
            // int avg= 0;
            // for(int i=0; i<arr.Length; i++)
            // {
            //     if(arr[i] > max)
            //     {
            //         max = arr[i];
            //     }
            //     if(arr[i] < min)
            //     {
            //         min = arr[i];
            //     }
            //     avg+=arr[i];
            // }
            // avg/=arr.Length;
            
            // System.Console.WriteLine(max);
            // System.Console.WriteLine(min);
            // System.Console.WriteLine(avg);

            // List<int> newArr= new List<int>();
            // newArr.Add(0);
            // for(int i=0; i < arr.Length; i++)
            // {
            //     newArr.Add(arr[i]);
            // }
            // arr=newArr.ToArray();
            // for(int i=0; i < arr.Length; i++)
            // {
            //     System.Console.WriteLine(arr[i]);
            // }
            List<object> mixedData = new List<object>();
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i]<0)
                {
                    mixedData.Add("Dojo");
                }
                else
                {
                    mixedData.Add(arr[i]);
                }
                System.Console.WriteLine(mixedData[mixedData.Count-1]);
            }
        }
    }
}
