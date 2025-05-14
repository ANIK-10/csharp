using System;
using System.Collections.Generic;

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Course { get; set; }
}

class Program
{
    static List<Student> students = new List<Student>();

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n--- Student Management System ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Search Student by Name");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    ViewStudents();
                    break;
                case 3:
                    SearchStudent();
                    break;
                case 4:
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 4);
    }

    static void AddStudent()
    {
        Student student = new Student();

        Console.Write("Enter Student ID: ");
        student.ID = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Student Name: ");
        student.Name = Console.ReadLine();

        Console.Write("Enter Course: ");
        student.Course = Console.ReadLine();

        students.Add(student);
        Console.WriteLine("Student added successfully!");
    }

    static void ViewStudents()
    {
        Console.WriteLine("\n--- List of Students ---");
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Course: {student.Course}");
        }
    }

    static void SearchStudent()
    {
        Console.Write("Enter Name to Search: ");
        string name = Console.ReadLine().ToLower();
        bool found = false;

        foreach (var student in students)
        {
            if (student.Name.ToLower().Contains(name))
            {
                Console.WriteLine($"Found: ID: {student.ID}, Name: {student.Name}, Course: {student.Course}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Student not found.");
        }
    }
}

