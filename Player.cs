public class Player
{
    public int score;
    public int diceRoll;

    // member variables (HAS A)


    // constructor (SPAWNER)


    public Player()
    {
        this.score = 0;
    }


    // member methods (CAN DO)
    public int getScore()
    {
        return this.score;
    }

    public void setScore(int score)
    {
        this.score = score;
    }

    public int getDiceRoll()
    {
        return this.diceRoll;
    }

    public void setDiceRoll(int diceRoll)
    {
        this.diceRoll = diceRoll;
    }


    public int RollDice()
    {
        Random rnd = new Random();
        int num = rnd.Next(1, 6);
        return num;
    }







}
