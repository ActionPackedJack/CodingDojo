﻿using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args){
            for (int i=1; i<101; i++){
                 if(i%3==0 && i%5==0){
                     Console.WriteLine(i + " FizzBuzz");
                 }
                 else if (i%3==0){
                     Console.WriteLine(i + " Fizz");
                 }
                 else if (i%5==0){
                     Console.WriteLine(i+ " Buzz");
                 }
            }
    }
}
}