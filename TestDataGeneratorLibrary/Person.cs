using System;
using System.Collections.Generic;
using System.Text;


namespace TestDataGeneratorLibrary
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        
        public enum Sex 
        {
            Male = 1,
            Female = 2
        }

        public static string[] firstNameMales = { "Paul", "Jack", "Grant", "Steve", "Michael", "Scott", "Colin", "Duncan" };
        public static string[] lastNames = { "McGregor", "Herring", "Hemingway", "Russels", "Darlington", "Boucher", "Trump", "McDavid" };
        public static string[] firstNameFemales = { "Lauren", "Catherine", "Stephanie", "Susan", "Lizzy", "Mathilda", "Anna", "Sasha" };
            
        
    }
}
