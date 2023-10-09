using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.Data;
namespace TestProject.Data_Access
{
  [Persistent("Order")]
  public class Order : XPObject
  {
    public Order(Session session) : base(session) { }


    [Association("Order-Movements")]
    XPCollection<Movement> movements
    {
      get { return GetCollection<Movement>(nameof(movements)); }
    }
    private string pNameOfOrder;
    public string NameOfOrder
    {
      get { return pNameOfOrder; }
      set { SetPropertyValue(nameof(NameOfOrder),ref pNameOfOrder, value); }
    }
  }
}
