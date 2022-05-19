public class DiceGame
{
    public int p1Score = 0;
    public int p2Score = 0;
    public int player1;
    public int player2;
    public bool continueGame = true;

    // string rollNumString = diceRoll.ToString();
    // System.Console.WriteLine(diceRoll);
    public static int RollDice()
    {
        Random rnd = new Random();
        int num = rnd.Next(1, 6);
        return num;
    }

    public void CompareRolls(int p1Roll, int p2Roll)
    {
        bool p1WinsRound = p1Roll > p2Roll;
        if (p1WinsRound)
        {
            p1Score += 1;
            System.Console.WriteLine("Player1 wins the round!");
            System.Console.WriteLine("Player1 score is: " + p1Score);
        }
        else
        {
            p2Score += 1;
            System.Console.WriteLine("Player2 wins the round!");
            System.Console.WriteLine("Player2 score is: " + p2Score);
        }
    }

    public void DisplayWinner()
    {
        bool p1Wins = p1Score > p2Score;
        if (p1Wins)
        {
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine("Player1 wins the game!");
            System.Console.WriteLine("----------------------");

        }
        else
        {
            {
                System.Console.WriteLine("----------------------");
                System.Console.WriteLine("Player2 wins the game!");
                System.Console.WriteLine("----------------------");
            }
        }
    }

    public bool CheckScore(int p1s, int p2s)
    {
        return p1s >= 3 || p2s >= 3;
    }

    public void PlayersRoll()
    {
        player1 = RollDice();
        player2 = RollDice();
    }

    public void EndGame()
    {
        bool verifyGameSetScore = CheckScore(p1Score, p2Score) == true;

        if (verifyGameSetScore)
        {
            continueGame = false;
        }
    }


    public void Rungame()
    {
        do
        {
            PlayersRoll();
            CompareRolls(player1, player2);
            CheckScore(p1Score, p2Score);
            EndGame();
        } while (continueGame);

        if (continueGame == false)
        {
            DisplayWinner();
        }
    }
}


