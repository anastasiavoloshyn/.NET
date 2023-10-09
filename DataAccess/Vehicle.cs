using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data;
using DevExpress.Xpo;

namespace TestProject.Data_Access
{
  [Persistent("Vehicle")]
  public class Vehicle : XPObject 
  {
    public Vehicle(Session session): base (session) { 
    }

    private string pVehicleNumber;
    
    public string VehicleNumber
    {
      get { return pVehicleNumber; }
      set { SetPropertyValue(nameof(VehicleNumber), ref pVehicleNumber, value); }
    }
    

    [Association("Driver-Vehicles")]
    public Driver driver {
      get { return GetPropertyValue<Driver>(nameof(driver)); }
      set { SetPropertyValue(nameof(driver), value); }
    }
    [Association("Vehicle-Movements")]
    public XPCollection<Movement> Movements
    {
      get { return GetCollection<Movement>(nameof(Movements)); }
    }
  }
}
