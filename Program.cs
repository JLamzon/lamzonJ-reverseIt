//Jessie Lamzom
//10/19/22
//GitHubChallenge - Redo mini Challenges
//Reverse it - data validation and play again


Console.Clear();

bool trueNumber;
int validNumber;

Console.WriteLine("Let's count backwards");

Console.WriteLine("Please provide your name\n");
string playerName = Console.ReadLine().ToUpper();

//update string to char array
char[] strArray = playerName.ToCharArray();
//reverse user input
Array.Reverse(strArray);
string reverse = new string(strArray);
Console.WriteLine($"Thanks {reverse}");

Console.WriteLine("Hmmm, your name was backwards.  Let's fix that...");
Console.WriteLine("");

string playAgain = "yes";

while (playAgain != "no")
{
    while (true)
    {
        Console.WriteLine($"{playerName}, enter some numbers and ill reverse it");
        Console.WriteLine("");
        string userNumber = Console.ReadLine();
        trueNumber = Int32.TryParse(userNumber, out validNumber);

        if (trueNumber == false)
        {
            Console.WriteLine("Are you using too many numbers or yet using letters? You got this, try again!\n");
        }
        else
        {
            strArray = userNumber.ToCharArray();
            Array.Reverse(strArray);
            reverse = new string(strArray);
            Console.WriteLine($"You entered {userNumber} and reverse is {reverse}");
            break;
        }
    }
    Console.WriteLine("");
    Console.WriteLine("Do you want to play again?\n\nPress any key or type 'no' to exit...");
    playAgain = Console.ReadLine();

}
Console.WriteLine("Thanks or playing");


