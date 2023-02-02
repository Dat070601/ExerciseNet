public class Family
{
    public int NumofPerson { get; set; }
    public string? Address { get; set; }
    public List<Person>? Persons { get; set; }

    
    public Family(List<Person> persons, string address, int numOfPerson)
    {
        Persons = persons;
        Address = address;
        NumofPerson = numOfPerson;
    }
}