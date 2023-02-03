public class Certificate
{
    public int CertificateID { get; set; }
    public string? CertificateName { get; set; }
    public string? CertificateRank { get; set; }
    public string? CertificateDate { get; set; }
    public Certificate(int certificatedID, string? certificateName, string? certificateRank, string? certificateDate)
    {
        CertificateID = certificatedID;
        CertificateName = certificateName;
        CertificateRank = certificateRank;
        CertificateDate = certificateDate;
    }
}