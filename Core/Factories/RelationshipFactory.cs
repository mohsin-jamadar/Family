using System.Collections.Generic;
using Family.Core.Interfaces;
using Family.Core.Models;

namespace Family.Core.Factories
{
    public class RelationshipFactory 
    {
        private Dictionary<string, IRelationship> _relationshipDictionary = new Dictionary<string, IRelationship>
        {
            { "Maternal-Uncle", new MaternalUncle() },
            {"Paternal-Uncle", new PaternalUncle() },
            {"Paternal-Aunt", new PaternalAunt() },
            {"Maternal-Aunt", new MaternalAunt() },
            {"Sister-In-Law", new SisterInLaw() },
            {"Brother-In-Law", new BrotherInLaw() },
            {"Son", new Son() },
            {"Daughter", new Daughter() },
            {"Siblings", new Sibling() }
        };
        
        public IRelationship GetRelationship(string relationshipName)
        {

            if (_relationshipDictionary.TryGetValue(relationshipName, out IRelationship relationship))
            {
                return relationship;
            }
            else
            {
                return null;
            }
        }
       

    }
}
