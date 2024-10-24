

namespace student_management_system
{
    public class Student
    {
        public string StudentName { get; set; }
        public int StudentID { get; set; }
        public int StudentAge { get; set; }
        public List<int> AllStudentGrades { get; set; }

        public Student(string studentName, int studentID, int studentAge, List<int> allStudentGrades)
        {

            StudentName = studentName;
            StudentID = studentID;
            StudentAge = studentAge;
            AllStudentGrades = allStudentGrades;

        }
    }
}
