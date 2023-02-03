class Intern : Employee
{
    public string Majors { get; set; }
    public int Semester { get; set; }
    public string University_Name { get; set; }
    public Intern(int id, string fullName, string birthDay, int employee_Type, int employee_Count, string majors, int semester, string university_Name, List<Certificate> cert) : base(id, fullName, birthDay, employee_Type, employee_Count, cert)
    {
        Majors = majors;
        Semester = semester;
        University_Name = university_Name;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine("Majors: " + Majors + " Semester: " + Semester + " University Name: " + University_Name);
    }
}