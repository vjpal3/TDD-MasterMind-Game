namespace TDDMasterMindGame
{
    public interface IGameStatus
    {
        bool GameIsWon { get; set; }

        void getStatus(int[] code, int[] attempt);
    }
}