using System.Collections.Generic;
using System.Linq;
using Family.Core.Interfaces;

namespace Family.Core.Models
{
    public class PaternalAunt : IRelationship
    {
        public List<string> GetAll(Person personHavingRelatives)
        {
            return new Sister().GetAll(personHavingRelatives?.Mother?.Spouse)?.Select(sister => sister?.Name).ToList();

        }

    }
}
