using Family.Core.Interfaces;
using System.Linq;
using System.Collections.Generic;

namespace Family.Core.Models
{
    public class BrotherInLaw : IRelationship
    {


        public  List<string> GetAll(Person personHavingRelatives)
        {
            var brothersOfSpouse = new Brother().GetAll(personHavingRelatives?.Spouse)?.Select(brother => brother?.Name).ToList();
            var husbandsOfSisters = new Sister().GetAll(personHavingRelatives)?.Where(sister => sister?.Spouse != null).Select(sister => sister?.Spouse?.Name).ToList();

            var brotherInLaws = new List<string>();
            if (brothersOfSpouse != null && brothersOfSpouse.Count > 0)
            {
                brotherInLaws.AddRange(brothersOfSpouse);
            }
            if (husbandsOfSisters != null && husbandsOfSisters.Count > 0)
            {
                brotherInLaws.AddRange(husbandsOfSisters);
            }
            return brotherInLaws;

        }
    }
}
