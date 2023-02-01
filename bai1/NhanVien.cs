class NhanVien : CanBo
{
    private string? Role { get; set; }
    public NhanVien(string? name, int age, string? gender, string? address, string? role): base(name, age, gender, address)
    {
        Role = role;
    }
    public override void outPut(){
        base.outPut();
        Console.WriteLine(" Role: " + Role);
    }
}