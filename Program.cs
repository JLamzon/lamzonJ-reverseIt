//Jessie Lamzom
//10/19/22
//GitHubChallenge - Redo mini Challenges
//Reverse it - data validation and play again


Console.Clear();

string playAgain = "yes";

while (playAgain != "no")
{
    Console.WriteLine("Enter some characters to reverse it!\n");
    string userInput = Console.ReadLine();

    Console.WriteLine($"\nYour input:\n{userInput}");
    
    //for loop setting up condition to repeat user input in reverse
    Console.WriteLine("\nYour input in reverse:");
    for (int i = userInput.Length - 1; i >= 0; i--)
    {
        Console.Write(userInput[i]);
    }
    
    Console.WriteLine("\n");
    Console.WriteLine("Do you want to play again?\n\nPress any key or type 'no' to exit...");
    playAgain = Console.ReadLine().ToLower();
}

Console.WriteLine("Thanks or playing");