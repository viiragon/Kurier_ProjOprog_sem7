using System;
using System.Collections.Generic;
using System.Data.Entity;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Uzytkownik;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Kurier.Models.Context
{
  public class AplicationInitializer : DropCreateDatabaseIfModelChanges<ApplicationContext>
  {
    protected override void Seed(ApplicationContext context)
    {
      context.Kurierzy.Add(new DaneKuriera()
      {
        Adres = new Adres()
        {
          KodPocztowy = "44-444",
          Miasto = "Warszawa",
          NumerMieszkania = "2",
          Ulica = "Znanieckiego"
        },
        Nazwisko = "Kowalczyk",
        Imie = "Mariusz",
        NumerPracowanika = 22
      }
      );
      context.SaveChanges();

      //context.Roles.Add(new IdentityRole { Name = "Admin" });
      //context.Roles.Add(new IdentityRole { Name = "Moderator" });
      //context.Roles.Add(new IdentityRole { Name = "User" });
      //context.SaveChanges();
    }
  }
}