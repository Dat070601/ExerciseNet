﻿class Program
{
    public static void Main(string[] args){
        DocumentManagement documentManagement = new DocumentManagement();
        while(true){
            Console.WriteLine(" Welcome to the Program of Documents Management ");
            Console.WriteLine("==============================================");
            Console.WriteLine("|| Enter 1: To add new Documents            ||");
            Console.WriteLine("|| Enter 2: To delete Documents by Id       ||");
            Console.WriteLine("|| Enter 3: To show infomation of Document  ||");
            Console.WriteLine("|| Enter 4: To search for Documents by Type ||"); 
            Console.WriteLine("|| Enter 5: To Exit                         ||");
            Console.WriteLine("==============================================");
            int choose = Int32.Parse(Console.ReadLine());
            switch (choose)
            {
                case 5:
                    return;
                case 3:
                {
                    documentManagement.GetAllDocument();
                    break;
                }
                // case 1: {
                //     Console.WriteLine("Enter the quantity you want to add: ");
                //     int quantity = Int32.Parse(Console.ReadLine());
                //     for (int i = 0; i < quantity; i++)
                //     {                        
                //         Console.Write("Enter name: ");
                //         string? name = Console.ReadLine();
                //         Console.Write("Enter age: ");
                //         int age = Int32.Parse(Console.ReadLine());
                //         Console.Write("Enter gender: ");
                //         string? gender = Console.ReadLine();                   
                //         Console.Write("Enter address: ");
                //         string? address = Console.ReadLine();
                //         Console.WriteLine("====================================");
                //         Console.WriteLine("||Enter E: To insert new Engineer ||");
                //         Console.WriteLine("||Enter W: To insert new Worker   ||");
                //         Console.WriteLine("||Enter P: To insert new Personnel||");
                //         Console.WriteLine("====================================");
                //         string? chooseAdd = Console.ReadLine();
                //         switch (chooseAdd){
                //             case "E":
                //             {
                //                 Console.Write("Enter training: ");
                //                 string? training = Console.ReadLine();
                //                 CanBo engineer = new KySu(name,age,gender,address,training);
                //                 staffManagement.AddStaff(engineer);
                //                 break;
                //             }
                //             case "W":
                //             {
                //                 Console.Write("Enter level: ");
                //                 int level = Int32.Parse(Console.ReadLine());
                //                 CanBo worker = new CongNhan(name,age,gender,address,level);
                //                 staffManagement.AddStaff(worker);
                //                 break;
                //             }
                //             case "P":
                //             {
                //                 Console.Write("Enter Role: ");
                //                 string? role = Console.ReadLine();
                //                 CanBo personnel = new NhanVien(name,age,gender,address,role);
                //                 staffManagement.AddStaff(personnel);
                //                 break;
                //             }
                //         }
                //     }
                //     staffManagement.GetAllCanBos();
                //     break;
                // }
                case 2: {
                    Console.WriteLine("Enter Id for Delete: ");
                    int idDocs = Int32.Parse(Console.ReadLine());
                    documentManagement.RemoveDocuments(idDocs);
                    break;
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