namespace TDDMasterMindGame
{
    public interface IGameStatus
    {
        bool GameIsWon { get; set; }
        int CorrectNumbers { get; set; }
        int CorrectPositions { get; set; }

        void getStatus(int[] code, int[] attempt);
    }
}