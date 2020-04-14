using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataGeneratorLibrary
{
    public class TestDataGenerator
    {

        public static Person GenerateRandomPerson(Person.Gender gender = (Person.Gender)(-1),
            string firstName = null, string lastName = null)
        {
            int age = RandomInt(1, 100);

            if (gender == (Person.Gender)(-1))
            {
                gender = RandomGender();
            }

            if (firstName == null)
            {
                if (gender == Person.Gender.Male)
                {
                    firstName = RandomArrayString(Person.firstNameMales);
                }
                else
                {
                    firstName = RandomArrayString(Person.firstNameFemales);
                }
            }

            if (lastName == null)
            {
                lastName = RandomArrayString(Person.lastNames);
            }

            return new Person(firstName, lastName, age, gender);
        }

        public static int RandomInt(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }

        public static Person.Gender RandomGender()
        {
            return (Person.Gender)RandomInt(0, 2);
        }
        public static string RandomArrayString(string[] array)
        {
            int index = RandomInt(0, array.Length);
            return array[index];

        }
        public static T RandomIList<T>(IList<T> list)
        {
            int index = RandomInt(0, list.Count);
            return list[index];
        }

        static public void InputPerson(string first,
               string last, Person.Gender gender, int age = 20)
        {
            Console.WriteLine($"{first} {last}, {age}, {gender}");
          
        }

    }
}
