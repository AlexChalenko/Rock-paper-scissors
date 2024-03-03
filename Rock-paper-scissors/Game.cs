namespace Rock_paper_scissors;

public class Game
{
    private Random _random = new();

    public void Start()
    {
        while (true)
        {
            Console.WriteLine($"Выберите ваш ход ({string.Join(",", MoveFactory.AllowedMoves)}):");
            char playerMove = Console.ReadLine().FirstOrDefault();
            IMove move = MoveFactory.CreateMove(playerMove);

            // Генерация хода компьютера
            IMove computerMove = GetComputerMove();

            Console.WriteLine($"Компьютер выбрал: {computerMove}");

            // Определение победителя
            if (move.Wins(computerMove))
            {
                Console.WriteLine("Вы выиграли!");
            }
            else if (computerMove.Wins(move))
            {
                Console.WriteLine("Компьютер выиграл!");
            }
            else
            {
                Console.WriteLine("Ничья!");
            }

            Console.WriteLine("Сыграем ещё раз? (да/нет)");
            if (Console.ReadLine().ToLower() != "да")
            {
                break;
            }
        }
    }

    private IMove GetComputerMove()
    {
        var index = _random.Next(MoveFactory.AllowedMoves.Length);
        var move = MoveFactory.AllowedMoves[index];
        return MoveFactory.CreateMove(move);
    }
}