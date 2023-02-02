public class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public string IdCard { get; set; }
    public int DateUse { get; set; }
    public Room Room { get; set; }
    public Person(string name, int age, string idCard, int dateUse, Room room)
    {
        Name = name;
        Age = age;
        IdCard = idCard;
        DateUse = dateUse;
        Room = room;
    }
    public void outPut()
    {
        Console.WriteLine("Name: " + Name + ", Age: " + Age + ", IdCard: "+ IdCard + ", DateUse: " + DateUse + ", Room Type: " + Room.Category + ", RoomPrice: "+ Room.Price);
    }
}