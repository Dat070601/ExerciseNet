class Newspaper : Documents
{
    public string? DateTime { get; set; }
    public Newspaper(string id, string? publisher, int versions, string? dateTime) : base(id, publisher, versions)
    {
        DateTime = dateTime;
    }
    public override void outPut(){
        base.outPut();
        Console.WriteLine(" ,DateTime: " + DateTime);
    }
}