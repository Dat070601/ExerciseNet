class Experience : Employee
{
    public int ExplnYear { get; set; }
    public string? ProSkill { get; set; }
    
    public Experience(int id, string fullName, string birthDay, int employee_Type, int employee_Count, int explnYear , string proSkill, List<Certificate> certs) : base(id, fullName, birthDay, employee_Type, employee_Count, certs)
    {
        ExplnYear = explnYear;
        ProSkill = proSkill;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine(" ExplnYear: " + ExplnYear + ", ProSkill: " + ProSkill);
    }
}