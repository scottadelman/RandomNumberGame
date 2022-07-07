Console.WriteLine("Enter a number between 1 and 100:");
var r = new Random();
var randomNumber = r.Next(1, 100);
bool gameOver = false;

do
{
    var userInput = int.Parse(Console.ReadLine());

    if (userInput > randomNumber)
    {
        Console.WriteLine("Too High");
    }

    else if (userInput < randomNumber)
    {
        Console.WriteLine("Too Low");
    }

    else
    {
        Console.WriteLine("You got it! Good guess!");
        gameOver = true;
    }

}

while (gameOver == false);