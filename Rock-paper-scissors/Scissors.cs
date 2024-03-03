namespace Rock_paper_scissors;

// Класс "Ножницы"
public class Scissors : IMove
{
    public bool Wins(IMove move)
    {
        return move is Paper; // Ножницы побеждают бумагу
    }

    public override string ToString()
    {
        return "Ножницы";
    }
}
