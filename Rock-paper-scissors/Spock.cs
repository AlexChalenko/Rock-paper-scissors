namespace Rock_paper_scissors
{
    // Класс "Спок"
    public class Spock : IMove
    {
        public bool Wins(IMove move)
        {
            return move is Scissors || move is Rock; // Спок побеждает ножницы и камень
        }

        public override string ToString()
        {
            return "Спок";
        }
    }
}
