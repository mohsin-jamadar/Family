using System.Collections.Generic;
using System.Linq;
using Family.Core.Models.Enums;

namespace Family.Core.Models
{
   
    public class Person 
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Person Mother { get; set; }
        public Person Spouse { get; set; }
        public List<Person> Children { get; set; }

        public Person()
        {
            Children = new List<Person>();
        }

     
        public Person GetFamilyMemberByName(string personNametoFind)
        {
          return  GetPersonNodeByName(this, personNametoFind);

        }
        private  Person GetPersonNodeByName(Person personRoot, string personNametoFind)
        {


            if (personRoot.Name == personNametoFind)
            {

                return personRoot;

            }
            if (personRoot.Spouse != null)
            {

                if (personRoot.Spouse.Name == personNametoFind)
                {

                    return personRoot.Spouse;
                }


            }

            foreach (var child in personRoot.Children)
            {
                var person = GetPersonNodeByName(child, personNametoFind);
                if (person != null)
                {
                    return person;
                }
            }

            return null;

        }


    }
}
