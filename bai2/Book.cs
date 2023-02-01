class Book : Documents
{
    public string? ActorName { get; set; }
    public int Pages { get; set; }
    public Book(int id, string? publisher, string? versions, string? actorName, int pages) : base(id, publisher, versions)
    {
        ActorName = actorName;
        Pages = pages;
    }
    public override void outPut(){
        base.outPut();
        Console.WriteLine(" ,ActorName: " + ActorName + ", Pages: " + Pages);
    }
}