// See https://aka.ms/new-console-template for more information
Random randomNumber = new Random();
int compNumber=randomNumber.Next(1, 101);
while (true)
{
	Console.WriteLine("Guess a number (1-100)");
	string inputPlayer=Console.ReadLine();
	bool isTrue=int.TryParse(inputPlayer, out int playerNumber);
	if (isTrue )
	{
		if (playerNumber == compNumber)
		{
			Console.WriteLine("You guessed it!");	break;
		}
		else if (playerNumber < compNumber)
		{
			Console.WriteLine("Too Low");
		}
		else 
		{
			Console.WriteLine("Too Hight");
		}
        }
}
