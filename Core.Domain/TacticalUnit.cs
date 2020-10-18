using System.Collections.Generic;

namespace SAROM2.Core.Domain
{
  public class TacticalUnit : BaseIdentifier
  {
    public int MissionId { get; set; }
    public string Name { get; set; }
    public string PagingName { get; set; }
    public string Remarks { get; set; }
    public List<FunctionGroup> Functions { get; set; }
    public ETacticalUnitStatus Status { get; set; }
  }
}
