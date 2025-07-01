using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        string letter;
        string sign;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        int lastDigit = grade % 10;

        if (lastDigit >= 7)
        {

            sign = "+";
        }
        else if (lastDigit < 3)
        {

            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (letter == "A")
        {
            if (grade == 100)
            {
                sign = "";
            }
            else if (sign == "+")
            {
                sign = ""; 
            }
        }
        if (letter == "F" && (sign == "+" || sign == "-"))
        {
            sign = "";
        }
        Console.WriteLine($"{letter}{sign}");

        if (grade >= 70)
        {
            Console.Write("Congratulations you passed the course.");
        }
        else
        {
            Console.Write("You failed the course better luck next time.");
        }
    }
}