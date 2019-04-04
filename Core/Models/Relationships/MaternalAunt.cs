using System.Collections.Generic;
using System.Linq;
using Family.Core.Interfaces;


namespace Family.Core.Models
{
    public class MaternalAunt : IRelationship
    {
        public List<string> GetAll(Person personHavingRelatives)
        {
            return  new Sister().GetAll(personHavingRelatives?.Mother)?.Select(sister => sister?.Name).ToList(); 
        }

       
    }
}
