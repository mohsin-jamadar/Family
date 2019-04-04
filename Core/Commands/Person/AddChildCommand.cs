
using System.Collections.Generic;
using Family.Core.Interfaces;
using Family.Core.Models;
using Family.Core.Models.Enums;
using Family.Repository;

namespace Family.Core.Commands
{
    public class AddChildCommand : ICommand<Person>
    {

        public string Execute(Person personRoot,List<string> parameters)
        {
            
            if (parameters == null || parameters.Count<3)
            {
                return "INVALID_COMMAND";
            }
            var mother = personRoot.GetFamilyMemberByName(parameters[0]);

            if (mother == null)
            {
                return "PERSON_NOT_FOUND";
            }
            else if (mother.Gender != Gender.Female)
            {
                return "CHILD_ADDITION_FAILED";
            }
            else
            {
                var child = new Person() { Name = parameters[1], Gender = (parameters[2] == "Female" ? Gender.Female : Gender.Male), Mother = mother };
                mother.Children.Add(child);
                return "CHILD_ADDED";
            }
        }
    }
}
