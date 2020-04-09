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
            //TestDataGenerator testDataGenerator = new TestDataGenerator();
            //testDataGenerator.GetRandomStringFromArray();

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(TestDataGenerator.GenerateRandomPerson());
            }
            Console.WriteLine();
            Console.WriteLine(TestDataGenerator.GenerateRandomPerson(Person.Sex.Female));
        }
    }
}
