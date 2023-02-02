class HotelManagement
{
    public List<Person> Persons {get; set;}
    public HotelManagement()
    {
        Persons = new List<Person> {
            new Person("HOANG DAT", 22, "asd", 10, new RoomA()),
            new Person("HOANG DAT", 22, "asds", 1, new RoomB())
        };
    }
    public void AddPerson(Person person){
        var findPerson = Persons.Where(per => per.IdCard.Equals(person.IdCard)).FirstOrDefault();
        if(findPerson != null){
            Console.WriteLine("IdCard user is already exist!");
        }
        else
        {
            Persons.Add(person);
        }
        foreach (var item in Persons)
        {
            item.outPut();
        }
    } 
    public void RemovePerson(string idCard){
        var findPerson =  Persons.Where(per => per.IdCard.Contains(idCard)).FirstOrDefault();
        if(findPerson == null)
        {
            Console.WriteLine("Person is not found!");
        }
        else
        {
            Persons.Remove(findPerson);
        }
    }
    public int TotalMoney(string idCard){
        var findPerson = Persons.Where(per => per.IdCard.Contains(idCard)).FirstOrDefault();
        if(findPerson == null)
        {
            return 0;
        }
        return findPerson.DateUse * findPerson.Room.Price;
    }
    public void GetAllPersons(){
        foreach (var item in Persons)
        {
            item.outPut();
        }
    }
}