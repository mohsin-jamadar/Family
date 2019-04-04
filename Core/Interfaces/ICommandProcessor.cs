using System.Collections.Generic;

namespace Family.Core.Interfaces
{
    public interface ICommandProcessor
    {
        List<string> ProcessCommands(List<string> commandLines);
    }
}