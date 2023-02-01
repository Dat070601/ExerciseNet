class KySu : CanBo
{
    private string? Training { get; set; }
    public KySu(string? name, int age, string? gender, string? address, string? training) : base(name, age, gender, address)
    {
        Training = training;
    }
    public override void outPut(){
        base.outPut();
        Console.WriteLine(" Training: " + Training);
    }
}