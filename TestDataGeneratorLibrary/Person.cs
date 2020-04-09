using System;
using System.Collections.Generic;
using System.Text;


namespace TestDataGeneratorLibrary
{
    public class Person
    {
       
     
        public enum Sex 
        {
            Male = 1,
            Female = 2
        }

        public static string[] firstNameMales = { "Paul", "Jack", "Grant", "Steve", "Michael", "Scott", "Colin", "Duncan" };
        public static string[] firstNameFemales = { "Lauren", "Catherine", "Stephanie", "Susan", "Lizzy", "Mathilda", "Anna", "Sasha" };
        public static string[] lastNames = { "McGregor", "Herring", "Hemingway", "Russels", "Darlington", "Boucher", "Trump", "McDavid" };

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public Sex sex { get; set; }

        public Person(string first, string last, int age, Sex sex)
        {
            FirstName = first;
            LastName = last;
            Age = age;
            this.sex = sex;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Age}, {sex}";
        }
    }
}
