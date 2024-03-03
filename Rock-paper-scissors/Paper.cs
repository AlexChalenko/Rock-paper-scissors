namespace Rock_paper_scissors;

// Класс "Бумага"
public class Paper : IMove
{
    public bool Wins(IMove move)
    {
        return move is Rock; // Бумага побеждает камень
    }

    public override string ToString()
    {
        return "Бумага";
    }
}
