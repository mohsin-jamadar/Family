using System.Collections.Generic;
using Family.Core.Factories;
using Family.Core.Interfaces;
using Family.Core.Models;
using Family.Repository;

namespace Family.Core.Commands
{
    public class GetRelativesCommand : ICommand<Person>
    {
        public string Execute(Person personRoot,List<string> parameters)
        {
            if (parameters == null || parameters.Count < 2)
            {
                return "INVALID_COMMAND";
            }
            var personToSearchforRelatives = personRoot.GetFamilyMemberByName(parameters[0]);
            if (personToSearchforRelatives == null)
            {
                return "PERSON_NOT_FOUND";
            }
            var relationship = new RelationshipFactory().GetRelationship(parameters[1]);
            if (relationship == null)
            {
                return  "INVALID_COMMAND";
            }
           
            var relativeNames = relationship.GetAll(personToSearchforRelatives);
            if (relativeNames != null && relativeNames.Count > 0)
            {
                var relatives = string.Join(" ", relativeNames);
                return relatives;
            }
            return "NONE";
        }
    }
}
