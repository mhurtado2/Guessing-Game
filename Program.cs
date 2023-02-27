using System;

// namespace guessingGame
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }
// }

//make an app that invites user to guess a number
// read that answer 

Main();

void Main()
{
    Console.WriteLine("Guess The Secret Number if you DARE!");
    string answer = Console.ReadLine();
    int parsedAnswer = int.Parse(answer);
    Console.WriteLine(answer);
}
