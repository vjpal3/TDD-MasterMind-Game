namespace TDDMasterMindGame
{
    public interface IGameInputValidator
    {
        bool isValid(int[] attempt);
        bool inputOutOfBounds(int[] attempt);
        bool inputNotUnique(int[] attempt);
    }
}