public class Program
{
    public List<Family>? families;
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
        int record = town.families.Count();
        while(true)
        {
            Console.WriteLine(" Welcome to the Program of Town Management ");
            Console.WriteLine("*********************************************");
            Console.WriteLine("# Enter 1: To show infomations of families  #");
            Console.WriteLine("# Enter 2: To exit                          #");
            Console.WriteLine("*********************************************");
            int choose = Int32.Parse(Console.ReadLine());
            switch(choose){
                case 1:
                {
                    Console.WriteLine("Enter the number of families you want to see: ");
                    int n = Int32.Parse(Console.ReadLine());
                    if(n > record)
                    {
                        Console.WriteLine("Only " + record + "/" + n + " families was saved!");
                        for(int i = 0; i < record; i++){
                            Console.WriteLine("Family " + (i+1)  + " has "+ town.families[i].NumofPerson+ " Persons");
                            foreach (var item in town.families[i].Persons)
                            {
                                Console.Write("Name: " + item.Name + "Age: "+ item.Age + " Job"+ item.Job+ " Id: " + item.Id);
                                Console.WriteLine(" Address: "+ town.families[i].Address);   
                            }
                        }
                    }
                    if(n < record)
                    {
                        Console.WriteLine(n +"/"+record + " families!");
                        for(int i = 0; i < n; i++){
                            Console.WriteLine("Family " + (i+1)  + " has "+ town.families[i].NumofPerson+ " Persons");
                            foreach (var item in town.families[i].Persons)
                            {
                                Console.Write("Name: " + item.Name + "Age: "+ item.Age + " Job"+ item.Job+ " Id: " + item.Id);
                                Console.WriteLine(" Address: "+ town.families[i].Address);   
                            }
                        }
                        Console.WriteLine("**************************************");
                        Console.WriteLine("# Enter M: To show more infomations  #");
                        Console.WriteLine("# Enter E: To exit                   #");
                        Console.WriteLine("***************************************");
                        string? choose_step = Console.ReadLine();
                        switch (choose_step)
                        {
                            case"M":{
                                for(int i = 0; i < record; i++){
                                    Console.WriteLine("Family " + (i+1)  + " has "+ town.families[i].NumofPerson+ " Persons");
                                    foreach (var item in town.families[i].Persons)
                                    {
                                        Console.Write("Name: " + item.Name + "Age: "+ item.Age + " Job"+ item.Job+ " Id: " + item.Id);
                                        Console.WriteLine(" Address: "+ town.families[i].Address);   
                                    }
                                }
                                break;
                            }
                            case"E":{
                                break;
                            }
                            default:
                                Console.WriteLine("Exit");
                                break;
                        }
                    }
                    else{
                        Console.WriteLine("There are "+record + " families in a town.");
                        for(int i = 0; i < record; i++){
                            Console.WriteLine("Family " + (i+1)  + " has "+ town.families[i].NumofPerson+ " Persons");
                            foreach (var item in town.families[i].Persons)
                            {
                                Console.Write("Name: " + item.Name + "Age: "+ item.Age + " Job"+ item.Job+ " Id: " + item.Id);
                                Console.WriteLine(" Address: "+ town.families[i].Address);   
                            }
                        }
                    }
                    break;
                }
                case 2:
                {
                    return;
                }
                default:
                {
                    Console.WriteLine("Error!");
                    break;
                }
            }
        }
    }
}