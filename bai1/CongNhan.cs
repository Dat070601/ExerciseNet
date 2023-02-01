class CongNhan : CanBo
{
    private int Level { get; set; }

    public CongNhan(string? name, int age, string? gender, string? address, int level) : base(name, age, gender, address)
    {
        Level = level;
    }
    public override void outPut(){
        base.outPut();
        Console.WriteLine(" Level: " + Level);
    }
}