class Magazine : Documents
{
    public int Chapter { get; set; }
    public int Month { get; set; }
    public Magazine(int id, string? publisher, string? versions, int chapter, int month) : base(id, publisher, versions)
    {
        Chapter = chapter;
        Month = month;
    }
    public override void outPut(){
        base.outPut();
        Console.WriteLine(" ,Chapter: " + Chapter + ", Month: " + Month);
    }
}