using System.Linq;
using Family.Core.Models.Enums;
using Family.Core.Interfaces;
using System.Collections.Generic;

namespace Family.Core.Models
{
    public class Sister 
    {
        public IEnumerable<Person> GetAll(Person personHavingRelatives)
        {
            return personHavingRelatives?.Mother?.Children?.Where(child => child?.Gender == Gender.Female && child?.Name != personHavingRelatives?.Name); 
        }
    }
}
