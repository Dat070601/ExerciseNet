public class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Job { get; set; }
    public int Id { get; set; }

    public Person(string name, int age, string? job, int id)
    {
        Name = name;
        Age = age;
        Job = job;
        Id = id;
    }
    
    // public void OutPut
}