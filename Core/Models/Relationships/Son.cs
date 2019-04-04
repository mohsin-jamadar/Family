using System.Linq;
using Family.Core.Models.Enums;
using Family.Core.Interfaces;
using System.Collections.Generic;

namespace Family.Core.Models
{
    public class Son : IRelationship
    {
        public List<string> GetAll(Person personHavingRelatives)
        {
            return personHavingRelatives?.Children?.Where(child => child?.Gender == Gender.Male).Select(son => son?.Name).ToList();
        }
    }
}
