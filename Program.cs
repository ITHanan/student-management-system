namespace student_management_system
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the StudentGradsSystem

            StudentGradsSystem studentGradsSystem = new StudentGradsSystem();

            bool running = true;

            while (running)

            {

                Console.WriteLine("\n===== Student Grades System =====");
                Console.WriteLine("1. Add a Student");
                Console.WriteLine("2. Remove a Student");
                Console.WriteLine("3. Calculate Average Grade for a Student");
                Console.WriteLine("4. Show All Students and Their Grades");
                Console.WriteLine("5. Exit");
                Console.WriteLine("==================================");
                Console.Write("Choose an option (1-5): ");

                string? choice = Console.ReadLine()!;
                // ? choice could be "1", "Hello", or null if no input is provided.


                switch (choice) 
                {
                    case "1":
                        studentGradsSystem.AddStudent();
                        break;

                    case "2":
                        studentGradsSystem.RemoveStudent();
                        break;

                    case "3":
                        Console.Write("Enter the Student ID to calculate the average grade: ");
                        int studentId = Convert.ToInt32(Console.ReadLine());
                        studentGradsSystem.CalculateAverageGrade(studentId);
                        break;

                    case "4":
                        studentGradsSystem.ShowAllStudentGrade();
                        break;

                    case "5":
                        Console.WriteLine("Exit");
                        running = false;
                        break;


                   default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }
}
