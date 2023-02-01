public class DocumentManagement
{
    public List<Documents> ListDocuments;
    public DocumentManagement()
    {
        ListDocuments = new List<Documents>(){
            new Book("Book001","KimDong",100,"HoangDat",90),
            new Newspaper("Newspapper001","HoangDat",100,"07-06-2022"),
            new Book("Book002","NhiDong",90,"LeHuy",100),
            new Magazine("Magazine001","NhiDong",67,01,01)
        };
    }
    public void AddDocuments(Documents documents){
        var findDocsId = ListDocuments.Where(doc => doc.Id.Contains(documents.Id)).FirstOrDefault();
        if(findDocsId != null)
        {
            Console.WriteLine("Documents is already exists!");
        }
        else
        {
            ListDocuments.Add(documents);
        }
    }
    public void RemoveDocuments(string idDocument){
        var docs = ListDocuments.Where(doc => doc.Id.ToLower().Contains(idDocument.ToLower())).FirstOrDefault();
        if(docs == null)
            Console.WriteLine("Documents not exists!");
        else
            ListDocuments.Remove(docs);
    }
    public void GetAllDocument(){
        foreach (var item in ListDocuments)
        {
            item.outPut();            
        }
    }
    public void SearchDocumentsByPublisher(IEnumerable<Documents> typeDoc)
    {
        Console.WriteLine("Enter name of publisher to search: ");
        string? publisherName = Console.ReadLine();
        var listByPublisher = typeDoc.Where(byDoc => byDoc.Publisher.ToLower().Contains(publisherName.ToLower()));
        if(listByPublisher == null)
        {
            Console.WriteLine("No publisher found");
        }
        else
            foreach (var itemBook in listByPublisher)
            {
                Console.WriteLine("List Books: ");
                itemBook.outPut();
            }
    }
    public void SearchDocumentsByTypes(string type)
    {
        if(type == "Book")
        {
            var listBook = ListDocuments.Where(doc => doc.GetType() == typeof(Book));
            foreach(var item in listBook)
            {
                Console.WriteLine("List Books: ");
                item.outPut();
            }
            SearchDocumentsByPublisher(listBook);
        }
        if(type == "Magazine")
        {
            var listMagazine = ListDocuments.Where(doc => doc.GetType() == typeof(Magazine));
            foreach (var item in listMagazine)
            {
                Console.WriteLine("List Magazine: ");
                item.outPut();
            }
            SearchDocumentsByPublisher(listMagazine);
        }
        if(type == "Newspaper")
        {
            var listNewspaper = ListDocuments.Where(doc => doc.GetType() == typeof(Newspaper));
            foreach (var item in listNewspaper)
            {
                Console.WriteLine("List Newspaper: ");
                item.outPut();
            }
            SearchDocumentsByPublisher(listNewspaper);
        }
    }

}