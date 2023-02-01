class Magazine : Documents
{
    public int Chapter { get; set; }
    public int Month { get; set; }
    public Magazine(string id, string? publisher, int versions, int chapter, int month) : base(id, publisher, versions)
    {
        Chapter = chapter;
        Month = month;
    }
    public override void outPut(){
        base.outPut();
        Console.WriteLine(" ,Chapter: " + Chapter + ", Month: " + Month);
    }
}