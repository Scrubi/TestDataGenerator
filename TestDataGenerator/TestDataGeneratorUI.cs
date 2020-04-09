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
            TestDataGenerator testDataGenerator = new TestDataGenerator();
            testDataGenerator.GetRandomStringFromArray();
        }
    }
}
