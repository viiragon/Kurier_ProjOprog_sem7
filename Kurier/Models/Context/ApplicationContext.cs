using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Kurier.Models.DataAccess;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Paczka;
using Kurier.Models.DTO.Samochod;
using Kurier.Models.DTO.Uzytkownik;
using Kurier.Views;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Kurier.Models.Context
{
  public class ApplicationContext : IdentityDbContext<DaneAuth>
  {
    public virtual DbSet<DaneKlienta> Klienci { get; set; }
    public virtual DbSet<DanePaczki> Paczki { get; set; }
    public virtual DbSet<DaneSamochodu> Samochody { get; set; }
    //public virtual DbSet<DaneUzytkownika> Uzytkownicy { get; set; }
    public virtual DbSet<DaneKuriera> Kurierzy { get; set; }

    public virtual DbSet<DaneUzytkownika> Uzytkownicy { get; set; }

    public ApplicationContext() : base("ApplicationContext")
    {
    //  Database.SetInitializer<ApplicationContext>(new AplicationDbInitializer());
    }

    public void FixEfProviderServicesProblem()
    {
      //The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
      //for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
      //Make sure the provider assembly is available to the running application. 
      //See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.

      var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
    }

  }
}