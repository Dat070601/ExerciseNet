class Program
{
    public static void Main(string[] args){
        StudentManagement studentManagement = new StudentManagement();
        while(true){
            Console.WriteLine(" Welcome to the Program of Student Management ");
            Console.WriteLine("==============================================");
            Console.WriteLine("|| Enter 1: To add new Student              ||");
            Console.WriteLine("|| Enter 2: To show infomation of Students  ||");
            Console.WriteLine("|| Enter 3: To search for Student by Id     ||"); 
            Console.WriteLine("|| Enter 4: To Exit                         ||");
            Console.WriteLine("==============================================");
            int choose = Int32.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1: {
                    Console.WriteLine("Enter the number of Students you want to add: ");
                    int quantity = Int32.Parse(Console.ReadLine());
                    for (int i = 0; i < quantity; i++)
                    {                        
                        Console.Write("Enter Id of Student: ");
                        int id = Int32.Parse(Console.ReadLine());                   
                        Console.Write("Enter Name of Student: ");
                        string? nameStudent = Console.ReadLine();
                        Console.Write("Enter Address of Student: ");
                        string? address = Console.ReadLine();
                        Console.Write("Enter PriorityLevel of Student: ");
                        int priorityLevel = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("========================================");
                        Console.WriteLine("||Enter A: Insert student to group A  ||");
                        Console.WriteLine("||Enter B: Insert student to group B  ||");
                        Console.WriteLine("||Enter C: Insert student to group C  ||");
                        Console.WriteLine("========================================");
                        string? chooseAdd = Console.ReadLine();
                        switch (chooseAdd){
                            case "A":
                            {
                                Students addStudent = new GroupA(id, nameStudent, address, priorityLevel);
                                studentManagement.AddStudent(addStudent);
                                break;
                            }
                            case "B":
                            {
                                Students addStudent = new GroupB(id, nameStudent, address, priorityLevel);
                                studentManagement.AddStudent(addStudent);
                                break;
                            }
                            case "C":
                            {
                                Students addStudent = new GroupC(id, nameStudent, address, priorityLevel);
                                studentManagement.AddStudent(addStudent);
                                break;
                            }
                        }
                    }
                    studentManagement.GetAllStudent();
                    break;
                }
                case 2: {
                    studentManagement.GetAllStudent();
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Enter Id of Student to search: ");
                    int id = Int32.Parse(Console.ReadLine());
                    studentManagement.SearchStudentById(id);
                    break;
                }
                case 4:
                {
                    return;
                }
                default:
                {
                    Console.WriteLine("Error");
                    break;
                }
            }
        }
    }
}