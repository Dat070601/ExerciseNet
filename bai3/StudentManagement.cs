class StudentManagement
{
    public List<Students> Students { get; set; }
    public StudentManagement()
    {
        Students = new List<Students>(){
            new GroupA(1,"DINH HOANG DAT","THANH KHE",10),
            new GroupB(2,"HOANG LE HUY","NGU HANH SON",9),
            new GroupA(3,"HUYNH NGOC THINH","TRUONG CHINH",11),
        };
    }
    public void AddStudent(Students student){
        var findStudent = Students.Where(st => st.Id == student.Id).FirstOrDefault();
        if(findStudent != null)
        {
            Console.WriteLine("Student is already exist!");
        }
        else
        {
            Students.Add(student);
        }
    }
    public void GetAllStudent()
    {
        foreach(var item in Students)
        {
            item.OutPut();
        }
    }
    public void SearchStudentById(int id)
    {
        var findStudent = Students.Where(st => st.Id == id).FirstOrDefault();
        if(findStudent == null)
        {
            Console.WriteLine("Student is already exist!");
        }
        else
        {
            findStudent.OutPut();
        }     
    }
}