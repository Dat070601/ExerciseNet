class EmployeeManagement
{
    public List<Employee> Employees;
    public EmployeeManagement()
    {
        Employees = new List<Employee>(){
            new Experience(1,"HOANG LE HUY", "01-01-2002", 0, 0,5,"ReactJs", new List<Certificate>(){new(1,"Toic","Normal","01-01-2021"), new(2,"Technology","Normal","01-01-2021")}),
            new Fresher(2,"Dinh Hoang Dat", "11-11-2001", 0, 1,"01-01-2023","Normal","BK", new List<Certificate>(){new(3,"Toic","Normal","01-01-2021")}),
            new Intern(3,"LE DAI HAI", "01-01-2002", 0, 0,"Marketing",4,"BK", new List<Certificate>(){new(4,"Toic","Normal","01-01-2021")})
        };
    }

    public void AddEmployee(Employee employee)
    {
        var FindEmployee = Employees.Where(x=>x.Id == employee.Id).FirstOrDefault();
        if(FindEmployee != null)
        {
            Console.Write(" ");
        }
        else
        {
            Employees.Add(employee);
        }
    }
    public void ShowInforEmployees()
    {
        foreach (var item in Employees)
        {
            item.ShowInfo();
        }
    }
}