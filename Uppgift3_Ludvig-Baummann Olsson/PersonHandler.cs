using System.Collections.Generic;
using System.Text;

namespace Uppgift3_Ludvig_Baummann_Olsson
{
    internal class PersonHandler
    {
        public PersonHandler()
        {
        }

        private readonly List<Person> personList = new List<Person>();
        public List<Person> PersonList
        {
            get { return personList; }
        }

        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            return new Person(age, fname, lname, height, weight);
        }

        public void SavePerson(Person pers)
        {
            personList.Add(pers);
        }

        public string PersonToString(Person pers)
        {
            var result = new StringBuilder();
            result.AppendLine(
                $"Age: {pers.Age}\n" +
                $"First Name: {pers.FName}\n" +
                $"Last Name: {pers.LName}\n" +
                $"Height: {pers.Height} cm\n" +
                $"Weight: {pers.Weight} kg");
            return result.ToString();
        }

        public string GetAllSavedPersonsToString()
        {
            var result = new StringBuilder();
            foreach (var pers in personList)
            {
                result.AppendLine(PersonToString(pers));
            }
            return result.ToString();
        }
    }
}