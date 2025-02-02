using challeng2;
using System.Net;
using System.Xml.Linq;

namespace challeng2
{
    class Person
    {
        public Person(string name, int age, string address, string nationality)
        {
            Name = name;
            Age = age;
            Address = address;
            Nationality = nationality;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Nationality { get; set; }
    }

    class Student : Person
    {
        public Student(string name, int age, string address, string nationality,int studyLevel, int gPA, string specalization)
         : base(name,age,address,nationality)
        {
            StudyLevel = studyLevel;
            GPA = gPA;
            Specalization = specalization;
        }

        public int StudyLevel { get; set; }
        public int GPA { get; set; }
        public string Specalization { get; set; }
    }



    class Employee : Person
    {
        public Employee( string name, int age, string address, string nationality,int salary)
           : base(name,age,address,nationality)
        {
            Salary = salary;
        }

        public int Salary { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

}