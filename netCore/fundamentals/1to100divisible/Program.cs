using System;

namespace _1to100divisible
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=1; i<101;i++){
                if(i%3==0 || i%5==0){
                    if(i%15!=0){
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
