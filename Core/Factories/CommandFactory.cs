using System.Collections.Generic;
using Family.Core.Commands;
using Family.Core.Interfaces;
using Family.Core.Models;
using Family.Repository;

namespace Family.Core.Factories
{
   
    public class CommandFactory<T> : ICommandFactory<T> where T : class
    {
        private Dictionary<string, ICommand<T>> _dictionary;
       

        public CommandFactory(Dictionary<string, ICommand<T>> commandDictionary)
        {

            _dictionary = commandDictionary;
        }


        public ICommand<T> GetCommand(string commandName)
        {

            if (_dictionary.TryGetValue(commandName, out ICommand<T> command))
            {
                return command;
            }
            else
            {
                return null;
            }
        }

 
    }
}
