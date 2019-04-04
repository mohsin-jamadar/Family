using System.Linq;
using Family.Core.Models.Enums;
using Family.Core.Interfaces;
using System.Collections.Generic;

namespace Family.Core.Models
{
    public class Daughter : IRelationship
    {
        public List<string> GetAll(Person personHavingRelatives)
        {
            return personHavingRelatives?.Children?.Where(child => child?.Gender == Gender.Female).Select(daughter => daughter?.Name).ToList();
        }

    }
}
