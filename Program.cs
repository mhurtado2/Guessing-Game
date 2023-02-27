using System;

//phase 1 
//make an app that invites user to guess a number
// read that answer 

//phase 2
// create a variable to contain secret number
//42 is secret number
// you condition statement to compare users guess to secret num

//phase 3 give user 4 chances to guess

//phase 4
//End the loop early if the user guesses the correct number.
//Display the number of the user's current guess in the prompt.
// For example, if the user has already guessed one time, the prommpt should say something like Your guess (2)>.

//phase 5
//Use a random number to set the secret number between 1 and 100 instead of a hard-coded number.





Main();

void Main()
{
    Console.WriteLine("Guess The Secret Number if you DARE!");

    int SecretNumber()
    {
        int numberValue = new Random().Next(1, 100);
        Console.WriteLine(numberValue);
        return numberValue;

    }

    int Guess(int number)
    {
        // int secretNum = SecretNumber();
        string answer = Console.ReadLine();
        int parsedAnswer = int.Parse(answer);


        if (number == parsedAnswer)
        {
            Console.WriteLine("You Are Correct!");
        }
        else
        {
            Console.WriteLine("You Are Wrong!");
        }
        return parsedAnswer;
    }

    int secretNum = SecretNumber();

    for (int i = 1; i <= 4; i++)
    {
        int try1 = Guess(secretNum);
        if (try1 != secretNum)
        {
            Console.WriteLine($"{i} guess complete, out of 4");
        }
        if (try1 == secretNum)
        {
            break;
        }

    }


}
