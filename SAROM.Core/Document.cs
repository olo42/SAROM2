using Core.Domain;

namespace SAROM2.Core.Domain
{
  public class Document : BaseIdentifier
  {
    public string Name { get; set; }
    public string Path { get; set; }
    public EDocumentType Type { get; set; }
  }
}
