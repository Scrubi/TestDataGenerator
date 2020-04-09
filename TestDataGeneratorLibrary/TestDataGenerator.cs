using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataGeneratorLibrary
{
    public class TestDataGenerator
    {
 
        public static string GetRandomStringFromArray(string[] array)
        {
            int index = RandomInt(0, array.Length);
            return array[index];

        }

        public static T GetRandomFromIList<T>(IList<T> list)
        {
            int index = RandomInt(0, list.Count);
            return list[index];
        }

        public static Person GenerateRandomPerson(Person.Sex sex = (Person.Sex)(-1),
            string firstName = null, string lastName = null)
        {
            int age = RandomInt(0, 100);

            if (sex == (Person.Sex)(-1))
            {
                sex = RandomSex();
            }

            if (firstName == null)
            {
                if (sex == Person.Sex.Male)
                {
                    firstName = GetRandomStringFromArray(Person.firstNameMales);
                }
                else
                {
                    firstName = GetRandomStringFromArray(Person.firstNameFemales);
                }
            }

            if (lastName == null)
            {
                lastName = GetRandomStringFromArray(Person.lastNames);
            }

            return new Person(firstName, lastName, age, sex);
        }

   
        public static int RandomInt(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }

        public static Person.Sex RandomSex()
        {
            return (Person.Sex)RandomInt(1, 2);
        }



    }
}
