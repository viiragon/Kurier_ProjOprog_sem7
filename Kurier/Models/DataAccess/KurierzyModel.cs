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
    private ApplicationContext _context;

    public KurierzyModel()
    {
      _context=new ApplicationContext();
    }

    public KurierzyModel(ApplicationContext context)
    {
      _context = context;
    }

    public void DodajKuriera(DaneKuriera kurier)
    {
        _context.Kurierzy.Add(kurier);
        _context.SaveChanges();
    }

    public DaneKuriera PobierzKuriera(int id)
    {
        return _context.Kurierzy.FirstOrDefault(p=>p.Id==id);
    }

    public List<DaneKuriera> PobierzListeKurierow()
    { 
        return _context.Kurierzy.ToList();
    }

    public List<DanePaczki> PobierzListePaczekKuriera(int idKuriera)
    {
        return _context.Paczki.Where(p=>p.Status!=null).Where(p=>p.Status.Kurier!=null).Where(p=>p.Status.Kurier.Id==idKuriera).ToList();
    }

    public DaneSamochodu PobierzSamochodKuriera(int idKuriera)
    {
        return _context.Samochody.Where(p=>p.Kurier!=null).FirstOrDefault(p=>p.Kurier.Id==idKuriera);
    }

    //TODO: zaimplementoiwać walidację
    public bool WalidujDaneKuriera(DaneKuriera kurier)
    {
      throw new NotImplementedException();
    }
  }
}