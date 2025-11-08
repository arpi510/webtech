using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    using System;

     class Student
     {
         public int id;
         public string name;
         public double cgpa;
     }

     struct Program
     {
         static void Main()
         {

             Student student1 = new Student();
             Student student2 = new Student();

             student1.id = 1;
             student1.name = "rid";
             student1.cgpa = 3.55;

             student2.id = 2;
             student2.name = "Arpita";
             student2.cgpa = 3.75;

             Console.WriteLine("Student 1 Details: ID: " + student1.id + ", Name: " + student1.name + ", CGPA: " + student1.cgpa);
             Console.WriteLine("Student 2 Details: ID: " + student2.id + ", Name: " + student2.name + ", CGPA: " + student2.cgpa);
             Console.ReadKey();
         }
     }
 }
   