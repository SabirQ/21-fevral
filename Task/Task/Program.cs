using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Avaz", "Avazli");
            Student student1 = new Student("Aydin", "Kerimov");
            Student student2 = new Student("Kamil", "Quluzade");
            Group group = new Group("P127", 8);
            group.AddStudent(student);            
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.GetStudent();


        }
    }
}
