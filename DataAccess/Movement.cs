using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.Data;

namespace TestProject.Data_Access
{
  public enum MovementType
  {
    Load = 1,
    Unload = 2
  }

  [Persistent("Movement")]
  public class Movement : XPObject 
  {
    public Movement(Session session): base(session) { }
    private MovementType movementType;
    public MovementType MovementType
    {
      get { return movementType; }
      set { SetPropertyValue(nameof(MovementType), ref movementType, value); }
    }

    private string pStartAdress;
    [Size(100)]
    public string StartAdress
    {
      get { return pStartAdress; }
      set { SetPropertyValue(nameof(StartAdress), ref pStartAdress, value); }
    }
    private string pEndAdress;
    [Size(100)]
    public string EndAdress
    {
      get { return pEndAdress; }
      set { SetPropertyValue(nameof(Encoder), ref pEndAdress, value); }
    }
    private double pStartLong;
    public double StartLong
    {
      get { return pStartLong; }
      set { SetPropertyValue(nameof(StartLong), ref pStartLong, value); }
    }
    private double pStartLat;
    public double StartLat
    {
      get { return pStartLat; }
      set { SetPropertyValue(nameof(StartLat), ref pStartLat, value); }
    }
    private double pEndLong;
    public double EndLong
    {
      get { return pEndLong; }
      set { SetPropertyValue(nameof(EndLong), ref pEndLong, value);}
    }
    private double pEndLat;
    public double EndLat
    {
      get { return pEndLat; }
      set { SetPropertyValue(nameof(EndLat), ref pEndLat, value);}
    }
    
    private DateTime pExpectedStartTime;
    public DateTime ExpectedStartTime
    {
      get { return pExpectedStartTime; }
      set { SetPropertyValue(nameof(ExpectedStartTime), ref pExpectedStartTime, value); }
    }
    
    private DateTime pActualStartTime;
    public DateTime ActualStartTime
    {
      get { return pActualStartTime; }
      set { SetPropertyValue(nameof(ActualStartTime), ref pActualStartTime, value); }
    }

    private DateTime pExpectedEndTime;

    public DateTime ExpectedEndTime
    {
      get { return pExpectedEndTime; }
      set { SetPropertyValue(nameof(ExpectedEndTime), ref pExpectedEndTime, value); }
    }


    private DateTime pActualEndTime;
    public DateTime ActualEndTime
    {
      get { return pActualEndTime; }
      set {SetPropertyValue(nameof(ActualEndTime), ref pActualEndTime, value); }
    }

    [Association("Order-Movements")]
    public Order Order
    {
      get { return GetPropertyValue<Order>(nameof(Order)); }
      set { SetPropertyValue(nameof(Order), value); }
        
    }
    [Association("Vehicle-Movements")] //one to many
    public Vehicle Vehicle
    {
      get { return GetPropertyValue<Vehicle>(nameof(Vehicle));}
      set { SetPropertyValue(nameof(Vehicle), value);}
    }

  }
}
