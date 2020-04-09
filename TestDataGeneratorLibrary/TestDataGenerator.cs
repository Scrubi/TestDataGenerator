using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataGeneratorLibrary
{
    public class TestDataGenerator : Person
    {
        public void GetRandomStringFromArray()
        {
            
            GenerateRandomPerson();

            static void GenerateRandomPerson()
            {
               
                Person person = new Person();
                Random random = new Random();
                
                int index = random.Next(firstNameMales.Length);
                _ = random.Next(lastNames.Length);
                _ = random.Next(firstNameFemales.Length);
                person.firstName = firstNameMales[index];
                person.lastName = lastNames[index];
                person.age = RandomInt();
                Console.WriteLine();
                Console.WriteLine($"Randomly selected person is {person.firstName} {person.lastName} {person.age}years old, person is: {RandomSex()}");
            }

            static int RandomInt()
            {
                int min = 1;
                int max = 99;
                Random random = new Random();
                int randomAge = random.Next(min, max);
                return randomAge;
            }

            static Sex RandomSex()
            {
                Array sex = Enum.GetValues(typeof(Sex));
                Random random = new Random();
                Sex randomSex = (Sex)sex.GetValue(random.Next(sex.Length));
                return randomSex;
            }
        }

       
      
    }
}
