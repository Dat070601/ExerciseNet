public abstract class Employee
{
    public int Id { get; }
    public string? FullName { get; set; }
    public string? BirthDay { get; set; }
    // public EmployeeType EmployeeType { get; set; }
    public int Employee_Type { get; set; }
    public int Employee_Count { get; set; }
    public List<Certificate> Certificates { get; set; }
    public Employee(int id, string fullName, string birthDay, int employee_Type, int employee_Count, List<Certificate> certs)
    {
        Id = id;
        FullName = fullName;
        BirthDay = birthDay;
        Employee_Type = employee_Type;
        Employee_Count = employee_Count;
        Certificates = certs;
    }

    public virtual void ShowInfo(){
        Console.Write("Full Name: " + FullName + ", Birth Day: " + BirthDay + ", Employee Count: " + Employee_Count + ", Employee_Type: " + Employee_Type);
    }
}