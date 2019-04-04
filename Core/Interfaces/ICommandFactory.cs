using Family.Core.Interfaces;

namespace Family.Core.Factories
{
    public interface ICommandFactory<T> where T : class
    {
        ICommand<T> GetCommand(string commandName);
    }
}