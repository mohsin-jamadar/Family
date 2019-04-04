using System.Collections.Generic;
using System.Linq;
using Family.Core.Interfaces;


namespace Family.Core.Models
{
    public class Sibling : IRelationship
    {
        public List<string> GetAll(Person personHavingRelatives)
        {
            return personHavingRelatives?.Mother?.Children?.Where(child => child?.Name != personHavingRelatives?.Name).Select(sibling => sibling?.Name).ToList();
        }

    }
}
