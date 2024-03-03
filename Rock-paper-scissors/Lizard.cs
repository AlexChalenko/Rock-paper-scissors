namespace Rock_paper_scissors
{
    // Класс "Ящерица"
    public class Lizard : IMove
    {
        public bool Wins(IMove move)
        {
            return move is Spock || move is Paper; // Ящерица побеждает Спока и бумагу
        }

        public override string ToString()
        {
            return "Ящерица";
        }
    }

}
