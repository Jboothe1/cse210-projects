using System;

class Program
{
    static void Main(string[] args){

      int x = 18;
      int NumberGuess = 0;

    while(NumberGuess != 18){
         Console.WriteLine("Guess the magic number: ");
         Random randomGenerator = new Random();
         NumberGuess = randomGenerator.Next(1, 100);
         Console.WriteLine($"Your guess was {NumberGuess}");
         // string valueInText = Console.ReadLine();
         // NumberGuess = int.Parse(valueInText);
         if (NumberGuess > x){
            Console.WriteLine("The magic number is smaller. Try again");
         }
         if (NumberGuess < x){
            Console.WriteLine("The magic number is larger. Try again");
         }
         if (NumberGuess == 18){
            Console.WriteLine("You guessed the magic number!");
          }
    }

       
    
    }
}