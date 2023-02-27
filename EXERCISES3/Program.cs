using System;
using System.Collections.Generic;

namespace EXERCISES3
{
    internal class Program
    {
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }

            public Student(int id, string name, int age)
            {
                Id = id;
                Name = name;
                Age = age;
            }
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(1, "Khanh", 20),
                new Student(2,"Tran",25),
                new Student(3,"Dinh",28),
            };

            students.Sort((s1,s2) => s1.Name.CompareTo(s2.Name));

            Console.WriteLine("Sinh vien sap xep theo ten: ");
            foreach (Student student in students)
            {
                Console.WriteLine($"ID: {student.Id} - Name: {student.Name} - Age: {student.Age}");
            }
            Console.ReadLine();
        }
    }
}
