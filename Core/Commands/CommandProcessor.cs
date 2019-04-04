using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Family.Core.Factories;
using Family.Core.Interfaces;

namespace Family.Core.Commands
{
    public class CommandProcessor<T> : ICommandProcessor where T : class
    {
        private ICommand<T> _command;
        private readonly IRepository<T> _repository;
        private readonly T _entity;
        private readonly ICommandDictionary<T> _commandDictionary;
        public CommandProcessor(IRepository<T> repository,ICommandDictionary<T> commandDictionary) 
        {

            _repository = repository;
            _entity = _repository.Get();
            _commandDictionary = commandDictionary;
        }

        public List<string> ProcessCommands(List<string> commandLines)
        {
            var output = new List<string>();
            var dictionary = _commandDictionary.GetDictionary();
            foreach (var line in commandLines)
            {
                var commandList = line.Split(' ');
                var command = commandList[0];
                var parameters = commandList.Skip(1).ToList();
                _command = new CommandFactory<T>(dictionary).GetCommand(command);


                if (_command == null)
                {
                    output.Add("INVALID_COMMAND");
                }
                else
                {
                    output.Add(_command.Execute(_entity, parameters));
                }


            }

            return output;

        }

    }
}
