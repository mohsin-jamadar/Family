using System.Linq;
using Family.Core.Models.Enums;
using Family.Core.Interfaces;
using System.Collections.Generic;

namespace Family.Core.Models
{
    public class Brother 
    {
        public IEnumerable<Person> GetAll(Person personHavingRelatives)
        {
            
            return personHavingRelatives?.Mother?.Children?.Where(child => child?.Gender == Gender.Male && child?.Name != personHavingRelatives?.Name);
        
        }
    }
}
