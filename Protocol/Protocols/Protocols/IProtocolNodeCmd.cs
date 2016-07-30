namespace Protocols
{
    public interface IProtocolNodeCmd
    {
        void Execute();
        void UndoExecute();
    }
}