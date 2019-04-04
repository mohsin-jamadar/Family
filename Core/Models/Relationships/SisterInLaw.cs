using System.Linq;
using Family.Core.Interfaces;
using System.Collections.Generic;

namespace Family.Core.Models
{
    public class SisterInLaw : IRelationship
    {
        public List<string> GetAll(Person personHavingRelatives)
        {
            var sistersOfSpouse =  new Sister().GetAll(personHavingRelatives?.Spouse)?.Select(sister => sister?.Name).ToList();
            var WivesOfBrother = new Brother().GetAll(personHavingRelatives)?.Where(brother => brother?.Spouse != null).Select(brother => brother?.Spouse?.Name).ToList();

            var sisterInLaws = new List<string>();
            if (sistersOfSpouse != null && sistersOfSpouse.Count > 0)
            {
                sisterInLaws.AddRange(sistersOfSpouse);
            }
            if (WivesOfBrother != null && WivesOfBrother.Count > 0)
            {
                sisterInLaws.AddRange(WivesOfBrother);
            }
            return sisterInLaws;
        }
    }
}
