using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Interfaces;
using Kurier.Interfaces.Model;
using Kurier.Models.Context;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Paczka;
using Kurier.Models.DTO.Samochod;
using Kurier.Models.DTO.Uzytkownik;

namespace Kurier.Models.DataAccess
{
  public class KurierzyModel : IMKurierzy
  {

    public void DodajKuriera(DaneKuriera kurier)
    {
      using (var db = new ApplicationContext())
      {
        db.Kurierzy.Add(kurier);
        db.SaveChanges();
      }
    }

    public DaneKuriera PobierzKuriera(int id)
    {
      using (var db = new ApplicationContext())
      {
        return db.Kurierzy.Find(id);
      }
    }

    public List<DaneKuriera> PobierzListeKurierow()
    {
      using (var db = new ApplicationContext())
      {
        return db.Kurierzy.ToList();
      }
    }

    public List<DanePaczki> PobierzListePaczekKuriera(int idKuriera)
    {
      using (var db = new ApplicationContext())
      {
        return db.Paczki.Where(p=>p.Status.Kurier.Id==idKuriera).ToList();
      }
    }

    public DaneSamochodu PobierzSamochodKuriera(int id)
    {
      using (var db = new ApplicationContext())
      {
        return db.Samochody.Find(id);
      }
    }

    //TODO: zaimplementoiwać walidację
    public bool WalidujDaneKuriera(DaneKuriera kurier)
    {
      throw new NotImplementedException();
    }
  }
}