
using Family.Core.Models.Enums;
using Family.Core.Interfaces;
using Family.Core.Models;
using System.Collections.Generic;

namespace Family.Repository
{
    public class PersonRepository : IRepository<Person>
    {

        public Person Get()
        {
            var kingArthur = CreateNewPerson("KingArthur", Gender.Male, null);
            var queenMargret = CreateNewPerson("QueenMargret", Gender.Female, null);
            Couple(kingArthur, queenMargret);

            var bill = CreateNewPerson("Bill", Gender.Male, queenMargret);
            var charlie = CreateNewPerson("Charlie", Gender.Male, queenMargret);
            var percy = CreateNewPerson("Percy", Gender.Male, queenMargret);
            var ronald = CreateNewPerson("Ronald", Gender.Male, queenMargret);
            var ginerva = CreateNewPerson("Ginerva", Gender.Female, queenMargret);

            queenMargret.Children.Add(bill);
            queenMargret.Children.Add(charlie);
            queenMargret.Children.Add(percy);
            queenMargret.Children.Add(ronald);
            queenMargret.Children.Add(ginerva);

            kingArthur.Children = queenMargret.Children;

            var flora = CreateNewPerson("Flora", Gender.Female, null);
            var audrey = CreateNewPerson("Audrey", Gender.Female, null);
            var helen = CreateNewPerson("Helen", Gender.Female, null);
            var harry = CreateNewPerson("Harry", Gender.Male, null);

            Couple(bill, flora);
            Couple(percy, audrey);
            Couple(ronald, helen);
            Couple(ginerva, harry);

            var victoire = CreateNewPerson("Victoire", Gender.Female, flora);
            var dominique = CreateNewPerson("Dominique", Gender.Female, flora);
            var louis = CreateNewPerson("Louis", Gender.Male, flora);

            flora.Children.Add(victoire);
            flora.Children.Add(dominique);
            flora.Children.Add(louis);
            bill.Children = flora.Children;

            var ted = CreateNewPerson("Ted", Gender.Male, null);
            Couple(victoire, ted);

            var remus = CreateNewPerson("Remus", Gender.Male, victoire);

            victoire.Children.Add(remus);
            ted.Children = victoire.Children;

            var molly = CreateNewPerson("Molly", Gender.Female, audrey);
            var lucy = CreateNewPerson("Lucy", Gender.Female, audrey);

            audrey.Children.Add(molly);
            audrey.Children.Add(lucy);
            percy.Children = audrey.Children;

            var malfoy = CreateNewPerson("Malfoy", Gender.Male, null);
            var rose = CreateNewPerson("Rose", Gender.Female, helen);
            var hugo = CreateNewPerson("Hugo", Gender.Male, helen);

            helen.Children.Add(rose);
            helen.Children.Add(hugo);
            ronald.Children = helen.Children;

            Couple(malfoy, rose);

            var draco = CreateNewPerson("Draco", Gender.Male, rose);
            var aster = CreateNewPerson("Aster", Gender.Female, rose);

            rose.Children.Add(draco);
            rose.Children.Add(aster);
            malfoy.Children = rose.Children;


            var james = CreateNewPerson("James", Gender.Male, ginerva);
            var albus = CreateNewPerson("Albus", Gender.Male, ginerva);
            var lily = CreateNewPerson("Lily", Gender.Female, ginerva);

            ginerva.Children.Add(james);
            ginerva.Children.Add(albus);
            ginerva.Children.Add(lily);
            harry.Children = ginerva.Children;

            var darcy = CreateNewPerson("Darcy", Gender.Female, null);
            var alice = CreateNewPerson("Alice", Gender.Female, null);

            Couple(james, darcy);
            Couple(albus, alice);

            var william = CreateNewPerson("William", Gender.Male, darcy);

            darcy.Children.Add(william);
            james.Children = darcy.Children;


            var ron = CreateNewPerson("Ron", Gender.Male, alice);
            var ginny = CreateNewPerson("Ginny", Gender.Female, alice);

            alice.Children.Add(ron);
            alice.Children.Add(ginny);
            albus.Children = alice.Children;

            return kingArthur;
        }

        private Person CreateNewPerson(string name, Gender gender, Person mother)
        {
            return new Person { Name = name, Gender = gender, Mother = mother };
        }

        private void Couple(Person husband, Person wife)
        {
            husband.Spouse = wife;
            wife.Spouse = husband;
        }

        
    }
   
}
