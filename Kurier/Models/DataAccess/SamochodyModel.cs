using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Interfaces.Model;
using Kurier.Models.Context;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Samochod;
using Kurier.Models.DTO.Uzytkownik;

namespace Kurier.Models.DataAccess
{
  public class SamochodyModel : IMSamochody
  {
    public void DodajSamochod(DaneSamochodu samochod)
    {
      using (var db = new ApplicationContext())
      {
        db.Samochody.Add(samochod);
        db.SaveChanges();
      }
    }

    public List<DaneSamochodu> PobierzListeSamochodow()
    {
      using (var db = new ApplicationContext())
      {
        return db.Samochody.ToList();
      }
    }

    public DaneSamochodu PobierzSamochod(int id)
    {
      using (var db = new ApplicationContext())
      {
        return db.Samochody.Find(id);
      }
    }

    public void PowiazKurieraISamochod(int idSamochodu, int idKuriera)
    {

      using (var db = new ApplicationContext())
      {
        DaneKuriera kurier=db.Kurierzy.FirstOrDefault(p => p.UserId == idKuriera);
        DaneSamochodu samochod = db.Samochody.Find(idSamochodu);

        if (samochod != null)
          kurier.Samochod= samochod;

        db.SaveChanges();
      }

    }

    public void UsunSamochod(int id)
    {
      using (var db = new ApplicationContext())
      {
        var samochod = db.Samochody.Find(id);
        db.Samochody.Remove(samochod);
        db.SaveChanges();
      }
    }

    public bool WalidujDaneSamochodu(DaneSamochodu samochod)
    {
      throw new NotImplementedException();
    }
  }
}