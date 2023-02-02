public class Program
{
    public static void Main(string[] args) {
        HotelManagement hotelManagement = new HotelManagement();
        Room room;
        while (true)
        {
            Console.WriteLine(" Welcome to the Program of Hotel Management ");
            Console.WriteLine("==============================================");
            Console.WriteLine("|| Enter 1: To add new Customers            ||");
            Console.WriteLine("|| Enter 2: To delete Customer by IdCard    ||");
            Console.WriteLine("|| Enter 3: To calculator price by IdCard   ||");
            Console.WriteLine("|| Enter 4: To show infor                   ||"); 
            Console.WriteLine("|| Enter 5: To Exit                         ||");
            Console.WriteLine("==============================================");
            int choose = Int32.Parse(Console.ReadLine());
            switch (choose){
                case 1: {
                    Console.WriteLine("Enter Name: ");
                    string? name = Console.ReadLine();
                    Console.WriteLine("Enter Age: ");
                    int age = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter IdCard: ");
                    string? idCard = Console.ReadLine();
                    Console.WriteLine("======================================");
                    Console.WriteLine("||Enter A: To choose room A         ||");
                    Console.WriteLine("||Enter B: To choose room B         ||");
                    Console.WriteLine("||Enter C: To choose room C         ||");
                    Console.WriteLine("======================================");
                    string chooseType = Console.ReadLine();
                    Console.WriteLine("Enter DateUse: ");
                    int dateUse = Int32.Parse(Console.ReadLine());
                    if(chooseType.Equals("A"))
                    {
                        room = new RoomA();
                        Person person = new Person(name,age,idCard,dateUse, room);
                        hotelManagement.AddPerson(person);
                    }
                    else if(chooseType.Equals("B"))
                    {
                        room = new RoomB();
                        Person person = new Person(name,age,idCard,dateUse, room);
                        hotelManagement.AddPerson(person);
                    }
                    else if(chooseType.Equals("C"))
                    {
                        room = new RoomC();
                        Person person = new Person(name,age,idCard,dateUse, room);
                        hotelManagement.AddPerson(person);
                    }
                    break;
                }
                case 2: 
                {
                    Console.WriteLine("Enter IdCard for Delete: ");
                    string? idCard = Console.ReadLine();
                    hotelManagement.RemovePerson(idCard);
                    Console.WriteLine("List after delete");
                    hotelManagement.GetAllPersons();
                    break;
                }
                case 3: 
                {
                    Console.WriteLine("Enter IdCard for Calculator: ");
                    string? idCard = Console.ReadLine();
                    int total = hotelManagement.TotalMoney(idCard);
                    Console.WriteLine("Total money: " + total);
                    break;
                }
                case 4:
                {
                    hotelManagement.GetAllPersons();
                    break;
                }
                case 5:
                    return;
                default:
                    Console.Write("Error");
                    break;
            }
        }
    }
}