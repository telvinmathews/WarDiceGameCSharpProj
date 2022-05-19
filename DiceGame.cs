public class DiceGame
{
    public int p1Score;
    public int p2Score;
    public bool continueGame;
    public Player player1;
    public Player player2;
    public int p1Roll;
    public int p2Roll;



    public DiceGame()
    {
        player1 = new Player();
        player2 = new Player();
        p1Score = player1.getScore();
        p2Score = player2.getScore();
        continueGame = true;
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
        p1Roll = player1.RollDice();
        p2Roll = player2.RollDice();
    }

    public void VerifyGameSetScore()
    {
        bool verifyGameSetScore = CheckScore(p1Score, p2Score) == true;

        if (verifyGameSetScore)
        {
            continueGame = false;
        }
    }

    public void EndGame()
    {
        if (continueGame == false)
        {
            DisplayWinner();
        }
    }


    public void RunGame()
    {
        do
        {
            PlayersRoll();
            CompareRolls(p1Roll, p2Roll);
            CheckScore(p1Score, p2Score);
            VerifyGameSetScore();
        } while (continueGame);

        EndGame();
    }
}


