namespace TDDMasterMindGame
{
    public interface IGameStatus
    {
        bool GameIsWon { get; set; }
        int CorrectNumbers { get; set; }

        void getStatus(int[] code, int[] attempt);
    }
}