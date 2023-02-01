public class Documents{
    
    public int Id { get; set; } 
    public string? Publisher { get; set; }
    public string? Versions { get; set; }
    public Documents(int id, string? publisher, string? versions)
    {
        Id = id;
        Publisher = publisher;
        Versions = versions;
    }
    public virtual void outPut()
    {
        Console.Write("Id: " +Id+" ,Publisher: "+ Publisher + " ,Versions: " + Versions);
    }
}