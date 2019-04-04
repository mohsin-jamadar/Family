using System.Collections.Generic;
using System.Linq;
using Family.Core.Factories;
using Family.Core.Interfaces;
using Family.Core.Models;
using Family.Repository;

namespace Family.Core.Commands
{
    public class PersonCommandProcessor : CommandProcessor<Person>
    {
        public PersonCommandProcessor(IRepository<Person> personRepository, ICommandDictionary<Person> personcommandDictionary) : base(personRepository, personcommandDictionary) { }

    }

   
}
