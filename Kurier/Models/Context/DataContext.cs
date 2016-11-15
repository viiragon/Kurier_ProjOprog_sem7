using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Kurier.Models.DTO;
using Kurier.Views;

namespace Kurier.Models.Context
{
  public class ApplicationContext : DbContext
  {
    public DbSet<DaneKlienta> Klienci { get; set; }
    public DbSet<DanePaczki> Paczki { get; set; }
    public DbSet<DaneSamochodu> Samochody { get; set; }
    public DbSet<DaneUzytkownika> Uzytkownicy { get; set; }
    public DbSet<DaneKuriera> Kurierzy { get; set; }

    public ApplicationContext()	: base("ApplicationContext")
		{
    }

  }
}