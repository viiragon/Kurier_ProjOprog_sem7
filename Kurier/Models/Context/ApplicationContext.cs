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

namespace Kurier.Models.Context
{
  public class ApplicationContext : DbContext
  {
    public virtual DbSet<DaneKlienta> Klienci { get; set; }
    public virtual DbSet<DanePaczki> Paczki { get; set; }
    public virtual DbSet<DaneSamochodu> Samochody { get; set; }
    public virtual DbSet<DaneUzytkownika> Uzytkownicy { get; set; }
    public virtual DbSet<DaneKuriera> Kurierzy { get; set; }

    public ApplicationContext()	: base("ApplicationContext")
		{
      Database.SetInitializer<ApplicationContext>(new AplicationDbInitializer());
    }

  }
}