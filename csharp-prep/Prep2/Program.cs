using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage for this class?");
        string valueInText = Console.ReadLine();
        int numberGrade = int.Parse(valueInText);
        string letter = "xx";
        if (numberGrade >= 90){
            letter = "A";
        }
        else if (numberGrade >= 80){
            letter = "B";
        }
        else if (numberGrade >= 70){
            letter = "C";
        }
        else if (numberGrade >= 60){
            letter = "D";
        }
        else {
            letter = "F";
        }
        Console.WriteLine($"Your letter grade is a(n) {letter}");
        if (numberGrade >=70){
            Console.WriteLine($"You passed the class!");
        }
        else {
            Console.WriteLine($"You failed the class, better luck next time!");
        }
    }
}