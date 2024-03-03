namespace Rock_paper_scissors;

// Класс "Камень"
public class Rock : IMove
{
    public bool Wins(IMove move)
    {
        return move is Scissors; // Камень побеждает ножницы
    }

    public override string ToString()
    {
        return "Камень";
    }
}
