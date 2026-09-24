using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask User for their Grade Percentage
        Console.WriteLine("What is your Grade Percentage? ");
        int gradePer = int.Parse(Console.ReadLine());

        //Check if the Grade Percentage is Valid
        if (gradePer >= 0 && gradePer <=100)
        {
            //Print the appropriate Letter Grade using IF/ELIF/ELSE statements
            string letterGrade = "";

            if (gradePer <= 100 && gradePer >= 90)
            {
                letterGrade = "A";
            }
            else if (gradePer >= 80)
            {
                letterGrade = "B";
            }
            else if (gradePer >= 70)
            {
                letterGrade = "C";
            }
            else if (gradePer >= 60)
            {
                letterGrade = "D";
            }
            else if (gradePer >= 0)
            {
                letterGrade = "F";
            }

            Console.WriteLine($"Your Letter Grade is: {letterGrade}");

            //If Grade Percentage >= 70 print "Passed the class" else "Try Harder Bud"

            if(gradePer >= 70)
            {
                Console.WriteLine("You passed the class!");
            }
            else
            {
                Console.WriteLine("Try Harder Bud");
            }
        }
        else
        {
            Console.WriteLine("Invalid Letter Grade, Please Try Again");
        }

    }
}