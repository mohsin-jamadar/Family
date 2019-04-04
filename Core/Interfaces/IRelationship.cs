using System.Collections.Generic;
using Family.Core.Models;

namespace Family.Core.Interfaces
{
    public interface IRelationship
    {
        List<string> GetAll(Person personHavingRelatives);
    }
}
