using TestDataGeneratorLibrary;
using System.Collections.Generic;
using System.Text;
using System;

namespace TestDataGeneratorUI
{
    public class TestDataGeneratorUI
    {
        public void InitializeUI()
        {
            TestDataGenerator.InputPerson("Hellen", "Sinclair", Person.Gender.Female);
            TestDataGenerator.InputPerson("Gwen", "Clark", Person.Gender.Female, 30);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(TestDataGenerator.GenerateRandomPerson());
            }
            Console.WriteLine("\n");
            Console.WriteLine(TestDataGenerator.GenerateRandomPerson(Person.Gender.Female));
            Console.WriteLine(TestDataGenerator.GenerateRandomPerson(Person.Gender.Male));
        }
    }
}
