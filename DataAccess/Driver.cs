using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.Data;
using DevExpress.Utils.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace TestProject.Data_Access
{
  [Persistent("Driver")]
  public class Driver : XPObject
  {
    public Driver(Session session) : base(session) { }

    private string pFirstName;
    [Size(100)]
    public string FirstName
    {
      get { return pFirstName; }
      set { SetPropertyValue(nameof(FirstName), ref pFirstName, value); }
    }
    private string pLastName;
    [Size(100)]
    public string LastName
    {
      get { return pLastName; }
      set { SetPropertyValue(nameof(LastName), ref pLastName, value); }
    }
    [Association("Driver-Vehicles")]
    public XPCollection<Vehicle> vehicles
    {
      get { return GetCollection<Vehicle>(nameof(vehicles)); }
    }
  }
}
