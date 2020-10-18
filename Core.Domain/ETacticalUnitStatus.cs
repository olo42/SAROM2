namespace SAROM2.Core.Domain
{
  public enum ETacticalUnitStatus
  {
    /* The following statuses are based on the status reports 
     * for fire brigade, rescue service and catatrophic protection */
    ReadyForUseOnRadio = 1,   // Einsatzbereit auf Funk
    MissionOrderAccepted = 3, // Auftrag übernommen
    ArrivedOnSite = 4,        // Am Einsatzort eingetroffen
    NotReadyForUse = 6,       // Nicht einsatzbereit
    BoundInUse = 7,           // Im Einsatz gebunden
  }
}
