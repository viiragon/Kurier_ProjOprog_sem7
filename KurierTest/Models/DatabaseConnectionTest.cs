using System;
using System.Data.Common;
using Kurier.Models.Context;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KurierTest.Models
{
  [TestClass]
  public class DatabaseConnectionTest
  {
    [TestMethod]
    public void TestConnection()
    {
      using (var db = new ApplicationContext())
      {
        DbConnection conn = db.Database.Connection;
        try
        {
          conn.Open();   // check the database connection
        }
        catch(Exception e)
        {
          throw new AssertFailedException();
        }
        Assert.IsTrue(db.Database.Exists());

      }
    }
  }
}
