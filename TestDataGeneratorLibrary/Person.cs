using System;
using System.Collections.Generic;
using System.Text;


namespace TestDataGeneratorLibrary
{
    public class Person
    {
       
     
        public enum Gender
        {
            Male = 0,
            Female
        }

        public static string[] firstNameMales = { "Paul", "Jack", "Grant", "Steve", "Michael", "Scott", "Colin", "Duncan" };
        public static string[] firstNameFemales = { "Lauren", "Catherine", "Stephanie", "Susan", "Lizzy", "Mathilda", "Anna", "Sasha" };
        public static string[] lastNames = { "McGregor", "Herring", "Hemingway", "Russels", "Darlington", "Boucher", "Trump", "McDavid" };

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public Gender gender { get; set; }

        public Person(string first, string last, int age, Gender gender)
        {
            FirstName = first;
            LastName = last;
            Age = age;
            this.gender = gender;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Age}, {gender}";
        }
    }
}
