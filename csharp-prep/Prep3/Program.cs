using System;

class Program
{
    static void Main(string[] args)
    {
        //Generate a random number between 1 and 100
        Random random = new Random();
        int randNum = random.Next(1, 101);

        //Console.WriteLine(randNum);

        //While Guess != Num,
        int guess = 0;
        while (guess != randNum)
        {
            //Get Guess from user input: What is your guess?
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            //Tell user if its higher, lower, or correct
            if (guess > randNum)
            {
                Console.WriteLine("Too High");
            }
            else if (guess < randNum)
            {
                Console.WriteLine("Too Low");
            }
            else
            {
                Console.WriteLine("You Guessed Corectly");
            }
        }


 
    }
}