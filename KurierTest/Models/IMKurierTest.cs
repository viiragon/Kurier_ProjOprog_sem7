using System.Linq;
using Kurier.Models.Context;
using Kurier.Models.DataAccess;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Uzytkownik;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KurierTest.Models
{
  [TestClass]
  public class IMKurierTest
  {
    [TestMethod]
    public void DodajKurieraTest()
    {
      DaneKuriera pobraneDaneKuriera;

      DaneKuriera daneKuriera = new DaneKuriera()
      {
        Adres = new Adres()
        {
          KodPocztowy = "44-44",
          Miasto = "Sierpc",
          NumerMieszkania = "2",
          Ulica = "Poniatowskiego"
        },
        Nazwisko = "Mirosławski",
        Imie = "Stanisław",
        NumerPracowanika = 100
      };


      new KurierzyModel().DodajKuriera(daneKuriera);

      using (var db = new ApplicationContext())
      {
        var x = db.Kurierzy.ToList();

        pobraneDaneKuriera = db.Kurierzy.FirstOrDefault(
          p => p.Imie == "Stanisław"
        && p.Nazwisko == "Mirosławski"
        && p.Adres.KodPocztowy == "44-44"
        && p.Adres.Miasto == "Sierpc"
          && p.Adres.NumerMieszkania == "2"
          && p.Adres.Ulica == "Poniatowskiego"
          && p.NumerPracowanika == 100
        );
      }

      Assert.IsNotNull(pobraneDaneKuriera);
      using (var db = new ApplicationContext())
      {
        db.Kurierzy.Attach(pobraneDaneKuriera);
        db.Kurierzy.Remove(pobraneDaneKuriera);
        db.SaveChanges();
      }
    }

    //void DodajKuriera(DaneKuriera kurier);
    //DaneKuriera PobierzKuriera(int id);
    //List<DaneKuriera> PobierzListeKurierow();
    //List<DanePaczki> PobierzListePaczekKuriera(int idKuriera);
    //DaneSamochodu PobierzSamochodKuriera(int id);
    //bool WalidujDaneKuriera(DaneKuriera kurier);
  }
}
