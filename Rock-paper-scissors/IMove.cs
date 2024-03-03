using System;
namespace Rock_paper_scissors
{
    // Интерфейс для ходов игры
    public interface IMove
    {
        bool Wins(IMove move); // Метод для определения победы над другим ходом
    }
}
