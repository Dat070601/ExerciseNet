public class StaffManagement 
{
    public List<CanBo> canBos;
    public StaffManagement()
    {
        canBos = new List<CanBo>(){
            new NhanVien("HUYNH NGOC THINH", 22, "Male", "TruongChinh", "IT"),
            new KySu("HOANG LE HUY", 21, "Male", "NguHanhSon","ReactJs")
        };
        // this.canBo = new CanBo();
    }

    public void AddStaff(CanBo staff){
        canBos.Add(staff);
    }
    public void SearchedStaffByName(string name){
        // this.canBo.setName(name);
        var listCB = canBos.Where(c => c.Name.Contains(name)).ToList();
        foreach (var item in listCB)
        {
            item.outPut();
        }
    }
    public void GetAllCanBos(){
        foreach (var item in canBos)
        {
            item.outPut();            
        }
    }
}