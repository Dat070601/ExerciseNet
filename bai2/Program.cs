class Program
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
                case 1: {
                    Console.WriteLine("Enter the number of Documents you want to add: ");
                    int quantity = Int32.Parse(Console.ReadLine());
                    for (int i = 0; i < quantity; i++)
                    {                        
                        Console.Write("Enter Id of Document: ");
                        string? id = Console.ReadLine();
                        Console.Write("Enter Name of Publisher: ");
                        string? namePublisher = Console.ReadLine();
                        Console.Write("Enter Number of Versions: ");
                        int versions = Int32.Parse(Console.ReadLine());                   
                        Console.WriteLine("======================================");
                        Console.WriteLine("||Enter B: To insert new Book       ||");
                        Console.WriteLine("||Enter M: To insert new Megazine   ||");
                        Console.WriteLine("||Enter N: To insert new Newspaper  ||");
                        Console.WriteLine("======================================");
                        string? chooseAdd = Console.ReadLine();
                        switch (chooseAdd){
                            case "B":
                            {
                                Console.Write("Enter Actor Name: ");
                                string? actorName = Console.ReadLine();
                                Console.Write("Enter Number of Pages: ");
                                int pages = Int32.Parse(Console.ReadLine());
                                Documents addBook = new Book(id, namePublisher, versions, actorName, pages);
                                documentManagement.AddDocuments(addBook);
                                break;
                            }
                            case "M":
                            {
                                Console.Write("Enter Chapter: ");
                                int chapter = Int32.Parse(Console.ReadLine());
                                Console.Write("Enter Release Month: ");
                                int month = Int32.Parse(Console.ReadLine());
                                Documents addMagazine = new Magazine(id, namePublisher, versions, chapter, month);
                                documentManagement.AddDocuments(addMagazine);
                                break;
                            }
                            case "N":
                            {
                                Console.Write("Enter Release Date: ");
                                string? releaseDate = Console.ReadLine();
                                Documents addNewspaper = new Newspaper(id, namePublisher, versions, releaseDate);
                                documentManagement.AddDocuments(addNewspaper);
                                break;
                            }
                        }
                    }
                    documentManagement.GetAllDocument();
                    break;
                }
                case 2: {
                    Console.WriteLine("Enter Id for Delete: ");
                    string? idDocs = Console.ReadLine();
                    documentManagement.RemoveDocuments(idDocs);
                    Console.WriteLine("List after delete");
                    documentManagement.GetAllDocument();
                    break;
                }
                case 3:
                {
                    documentManagement.GetAllDocument();
                    break;
                }
                case 4:
                {
                    Console.WriteLine("Enter type to search: ");
                    string? type = Console.ReadLine();
                    documentManagement.SearchDocumentsByTypes(type);
                    break;
                }
                case 5:
                    return;
                default:
                {
                    Console.WriteLine("Error");
                    break;
                }
            }
        }
    }
}