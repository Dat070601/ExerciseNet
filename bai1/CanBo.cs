public class CanBo
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Gender { get; set; }
    public string? Address { get; set; }

    public CanBo(string? name, int age, string? gender, string? address){
        Name = name;
        Age = age;
        Gender = gender;
        Address = address;
    }
    public virtual void outPut(){
        Console.Write("Name: " + Name + " Age: " + Age+ " Gender: " + Gender + " Address: " + Address);
    }
}