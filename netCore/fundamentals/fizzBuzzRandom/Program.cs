using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args){

            for (int j=0; j<10; j++){
                Random rand = new Random();
                int i= rand.Next(1,100);
                 if(i%3==0 && i%5==0){
                     Console.WriteLine(i + " FizzBuzz");
                 }
                 else if (i%3==0){
                     Console.WriteLine(i + " Fizz");
                 }
                 else if (i%5==0){
                     Console.WriteLine(i+ " Buzz");
                 }
                 else{
                     Console.WriteLine(i);
                 }
            }
        }
    }
}
