using System;

public class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number score you have in the class:");
        int grade = int.Parse(Console.ReadLine());
        if (grade >= 100){
            Console.WriteLine("Wow! 100... That's impressive!");
            Console.WriteLine("Letter grade: A+");
        }
        else if (grade >= 90){
            Console.WriteLine("Very nice!");
            Console.WriteLine("Letter grade: A");
        }
        else if (grade >= 80){
            Console.WriteLine("Keep it up!");
            Console.WriteLine("Letter grade: B");
        }
        else if (grade >= 70){
            Console.WriteLine("You got this, keep working!");
            Console.WriteLine("Letter grade: C");
        }
        else if (grade >= 60){
            Console.WriteLine("Keep trying!");
            Console.WriteLine("Letter grade: D");
        }
        else{
            Console.WriteLine("Don't give up!");
            Console.WriteLine("Letter grade: E");
        }
    }
}