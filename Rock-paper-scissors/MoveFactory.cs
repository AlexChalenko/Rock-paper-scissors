namespace Rock_paper_scissors;

public class MoveFactory
{
    public static char[] AllowedMoves = new[] { 'к', 'н', 'б', 'я', 'с' };
    public static IMove CreateMove(char moveName)
    {
        switch (moveName)
        {
            case 'к':
                return new Rock();
            case 'н':
                return new Scissors();
            case 'б':
                return new Paper();
            case 'я':
                return new Lizard();
            case 'с':
                return new Spock();
            default:
                throw new ArgumentException("Неверное название хода");
        }
    }
}

