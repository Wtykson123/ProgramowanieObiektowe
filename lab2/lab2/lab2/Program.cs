using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher treacher = new Teacher("Maria Skłodowska", 50);

            Student student1 = new Student("Jan Kowaslski", 21, "LAB-01");
            Student student2 = new Student("Jan Kowaslski", 21, "LAB-01");
            Student student3 = new Student("Jaś Fasola", 23, "LAB-02");
                                       __
                                      / _)
                             _.----._/ /
                            /         /
                         __/ (  | (  |
                        /__.-'|_|--|_|

            Person[] persons = { treacher, student1, student2, student3 };
            Classroom classroom = new Classroom("Sala Komputerowa", persons);

            Console.WriteLine(classroom);

            Console.WriteLine("student1 == student2: " + student1.Equals(student2)); // Output: student1 == student2: true
            Console.WriteLine("student1 == student3: " + student1.Equals(student3)); // Output: student1 == student3: false
        
    }
    }
    public class Person: IEquatable<Person>
    {

        protected String name;
        protected int age;

        public String Name { get => this.name; }
        public int Age { get => this.age; }

        public Person(String name, int age)
        {
            this.name = name;
            this.age = age;

        }
        public bool Equals(Person other)
        {

            if (other == null) return false;
            if (other == this) return true;

            return Object.Equals(this.name, other.name) && Object.Equals(other.name, other.age);

        }

        public override string ToString()
        {
            return $"(this.name) ({this.age} y.o.)";
        }

    }

    public class Teacher : Person
    {
    

        public Teacher(String name, int age):base(name,age)
        {
               
        
        }
        
        public override string ToString()
        {
            return $"Teacher: {base.ToString()}";
          
        }
    }






}
