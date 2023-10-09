using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.Xpo.DB;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestProject.Data_Access;

namespace TestProject
{
  internal static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      
      string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=TestProject;User ID=localadmin;Password=maso";
      
      IDataLayer dataLayer = XpoDefault.GetDataLayer(connectionString, AutoCreateOption.DatabaseAndSchema);
      UnitOfWork unitOfWork = new UnitOfWork(dataLayer);

      Movement movement = new Movement(unitOfWork)
      {
        StartAdress="Lviv",
      };

      unitOfWork.CommitChanges();
 
      Application.Run(new RibbonForm1());
    }
  }
}
