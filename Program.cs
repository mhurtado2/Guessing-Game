using System;

//phase 1 
//make an app that invites user to guess a number
// read that answer 

//phase 2
// create a variable to contain secret number
//42 is secret number
// you condition statement to compare users guess to secret num


//phase 3 give user 4 chances to guess


Main();

void Main()
{
    Console.WriteLine("Guess The Secret Number if you DARE!");

    int Guess()
    {
        int secretNum = 42;
        string answer = Console.ReadLine();
        int parsedAnswer = int.Parse(answer);


        if (secretNum == parsedAnswer)
        {
            Console.WriteLine("You Are Correct!");
        }
        else
        {
            Console.WriteLine("You Are Wrong!");
        }
        return parsedAnswer;
    }

    for (int i = 0; i < 4; i++)
    {
        int try1 = Guess();
        if (try1 == 42)
        {
            break;
        }
    }

    // public class Guess
    // {
    //     public int Value { get; set; }
    // }

    // public Guess(int value)
    // {
    //     this.Value = value;
    // }

}
