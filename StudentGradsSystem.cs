using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

namespace student_management_system
{
    public class StudentGradsSystem
    {
        public List<Student> elever = new List<Student>();

        public void AddStudent()
        {
            Console.WriteLine("Enter student Name: ");
            string studentName = Console.ReadLine()!;

            Console.WriteLine("Enter student ID:   ");
            int studentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Age: ");
            int studentAge = Convert.ToInt32(Console.ReadLine());

            List<int> allStudentGrades = new List<int>();
            bool addMoreGrades = true;

            while (addMoreGrades)
            {
                Console.WriteLine("Enter Grade: ");
                int studentGrade = Convert.ToInt32(Console.ReadLine());
                allStudentGrades.Add(studentGrade);

                Console.WriteLine("Do you want to add another grade? (yes/no): ");
                addMoreGrades = Console.ReadLine()?.ToLower() == "yes";
            }

            elever.Add(new Student(studentName, studentId, studentAge, allStudentGrades));
            Console.WriteLine($"The student {studentName} has been successfully entered");
        }


        public void RemoveStudent()
        {
            Console.WriteLine("Write the student name that you want to delete: ");
            string studentNameremove = Console.ReadLine()!;

            Console.WriteLine("Enter the student ID Number: ");
            int studentIdremove = Convert.ToInt32(Console.ReadLine());

            Student? removeStudentName = null;

            foreach (Student student in elever)
            {
                if (student.StudentName == studentNameremove && student.StudentID == studentIdremove)
                {

                    removeStudentName = student;
                    break;

                }
            }

            if (removeStudentName != null)
            {
                elever.Remove(removeStudentName);
                Console.WriteLine($"The Student {studentNameremove}has been deleted");
            }
            else
            {
                Console.WriteLine("Student name not found");
            }
        }


        public void CalculateAverageGrade(int studentId)

        {

            var student = elever.FirstOrDefault(x => x.StudentID == studentId);

            if (student == null)
            {
                Console.WriteLine($"there is no studentfaund by this Id number {studentId}");
                return;

            }

            if (student.AllStudentGrades.Count > 0)
            {
                double average = student.AllStudentGrades.Average();
                Console.WriteLine($"Average grade for student {studentId}: { average}");
            }
            else
            {
                Console.WriteLine("No grades is found for this student.");
            }


        }

        public void ShowAllStudentGrade()
        {
            Console.WriteLine("the list of all student and ther grade is: ");
            foreach (var student in elever)
            {
                Console.WriteLine($"Student: {student.StudentName},Grades: {string.Join(", ", student.AllStudentGrades)}");

                //fereach Student
            }

        }
    }
}