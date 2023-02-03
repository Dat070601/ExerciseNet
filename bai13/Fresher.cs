class Fresher : Employee
{
    public string? Graduation_Date { get; set; }
    public string? Graduation_Rank { get; set; }
    public string? Education { get; set; }
    public Fresher(int id, string fullName, string birthDay, int employee_Type, int employee_Count,
                    string graduation_Date, string graduation_Rank, string education, List<Certificate> cert) : base(id, fullName, birthDay, employee_Type, employee_Count,cert)
    {
        Graduation_Date = graduation_Date;
        Graduation_Rank = graduation_Rank;
        Education = education;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine("Graduation Date: " + Graduation_Date + ", Graduation Rank: " + Graduation_Rank + ", Education: "+ Education);
    }
}