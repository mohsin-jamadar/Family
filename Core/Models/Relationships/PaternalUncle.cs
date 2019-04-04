using System.Collections.Generic;
using System.Linq;
using Family.Core.Interfaces;


namespace Family.Core.Models
{
    public class PaternalUncle: IRelationship
    {
        public List<string> GetAll(Person personHavingRelatives)
        {
            return new Brother().GetAll(personHavingRelatives?.Mother?.Spouse)?.Select(brother => brother?.Name).ToList();
        }

    }
}
