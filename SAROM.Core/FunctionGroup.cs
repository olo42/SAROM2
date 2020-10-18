namespace SAROM2.Core.Domain
{
  public class FunctionGroup : BaseIdentifier
  {
    public Function Function { get; set; }
    public int Quantity { get; set; }
  }
}