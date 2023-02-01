class Newspaper : Documents
{
    public string? DateTime { get; set; }
    public Newspaper(int id, string? publisher, string? versions, string? dateTime) : base(id, publisher, versions)
    {
        DateTime = dateTime;
    }
    public override void outPut(){
        base.outPut();
        Console.WriteLine(" ,DateTime: " + DateTime);
    }
}