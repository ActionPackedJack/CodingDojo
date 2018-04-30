using System;

namespace fizzBuzzAlternate
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double i=1; i<101; i++){
                 if(i/3==Math.Floor(i/3) && i/5==Math.Floor(i/5)){
                     Console.WriteLine(i + " FizzBuzz");
                 }
                 else if (i/3==Math.Floor(i/3)){
                     Console.WriteLine(i + " Fizz");
                 }
                 else if (i/5==Math.Floor(i/5)){
                     Console.WriteLine(i+ " Buzz");
                 }
            }
            
        }
    }
}
