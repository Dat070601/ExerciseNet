public class DocumentManagement
{
    public List<Documents> ListDocuments;
    public DocumentManagement()
    {

    }
    public void AddDocuments(Documents documents){
        ListDocuments.Add(documents);
    }
    public void RemoveDocuments(int idDocument){
        var docs = ListDocuments.Where(doc => doc.Id == idDocument).FirstOrDefault();
        ListDocuments.Remove(docs);
    }
    public void GetAllDocument(){
        foreach (var item in ListDocuments)
        {
            item.outPut();            
        }
    }
}