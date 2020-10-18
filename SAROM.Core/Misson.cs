using System;
using System.Collections.Generic;

namespace SAROM2.Core.Domain
{
  public class Misson : BaseIdentifier
  {
    public string Objective { get; set; }
    public DateTime Alert { get; set; }
    public string ControlCenterReference { get; set; }
    public MissionType Type { get; set; }
    public List<Document> Documents { get; set; }
    public EMissionState State { get; set; }
    public List<TacticalUnit> Groups { get; set; }
  }
}
