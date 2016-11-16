using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Interfaces.Model;
using Kurier.Models.Context;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Paczka;
using Kurier.Models.DTO.Uzytkownik;

namespace Kurier.Models.DataAccess
{
  public class PaczkaModel : IMPaczki
  {
    public void DodajPaczke(DanePaczki paczka)
    {
      using (var db = new ApplicationContext())
      {
        db.Paczki.Add(paczka);
        db.SaveChanges();
      }
    }

    public List<DanePaczki> PobierzListePaczek()
    {
      using (var db = new ApplicationContext())
      {
        return db.Paczki.ToList();
      }
    }

    public DanePaczki PobierzPaczke(int id)
    {
      using (var db = new ApplicationContext())
      {
        return db.Paczki.Find(id);
      }
    }

    public void PowiazKurieraIPaczke(int idPaczki, int idKuriera)
    {
      DaneKuriera kurier = new KurierzyModel().PobierzKuriera(idKuriera);

      using (var db = new ApplicationContext())
      {
        DanePaczki paczka = db.Paczki.Find(idPaczki);
        if (paczka != null)
          paczka.Status.Kurier = kurier;

        db.SaveChanges();
      }
    }

    public bool WalidujDanePaczki(DanePaczki paczka)
    {
      throw new NotImplementedException();
    }

    public void ZmienStatusPaczki(Status status,int idPaczki)
    {
      using (var db = new ApplicationContext())
      {
        DanePaczki paczka = db.Paczki.Find(idPaczki);
        if (paczka != null)
        {
          paczka.Historia.Add(paczka.Status);
          paczka.Status = status;
          db.SaveChanges();
        }
      }
    }
  }
}