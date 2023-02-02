public class Program
{
    public List<Family> families;
    public static void Main(string[] args) {
        Town town = new Town()
        {
            families = new List<Family> {
                new Family(
                    new List<Person> {
                        new Person("LE DAI HAI", 23, "Intern", 123),
                        new Person("HOANG LE HUY", 22, "Intern", 321)
                    },
                    "NGU HANH SON",
                    2
                ),
                new Family(
                    new List<Person> {
                        new Person("DINH HOANG DAT",22,"Intern", 111),
                        new Person("HUYNH NGOC THINH", 22, "Intern",222)
                    },
                    "THANH KHE",
                    2
                ),
                new Family(
                    new List<Person>{
                        new Person("NGUYEN THI HAI YEN", 25,"Intern",333),
                        new Person("NGUYEN QUANG TRIEU", 24,"Intern",444)
                    },
                    "HOA KHANH",
                    2
                )
            }
        };
        Console.WriteLine("Enter n: ");
        int n = Int32.Parse(Console.ReadLine());
        for(int i = 1; i <= n; i++)
        {
            Console.WriteLine("Family " + i + " has "+ town.families[i-1].NumofPerson+ " Persons");
            foreach (var item in town.families[i-1].Persons)
            {
                Console.Write("Name: " + item.Name + "Age: "+ item.Age + " Job"+ item.Job+ " Id: " + item.Id);
                Console.WriteLine(" Address: "+ town.families[i-1].Address);   
            }
        }
    }
}