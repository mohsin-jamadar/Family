using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Family.Core.Commands;
using Family.Core.Interfaces;
using Family.Core.Models;

namespace Family.Core.Factories
{
    public class PersonCommandDictionary :ICommandDictionary<Person>
    {

        public  Dictionary<string, ICommand<Person>> GetDictionary()
        {
            return new Dictionary<string, ICommand<Person>>
            {
                { "ADD_CHILD", new AddChildCommand() },
                { "GET_RELATIONSHIP", new GetRelativesCommand() }
            };
        }
    }

   
}
