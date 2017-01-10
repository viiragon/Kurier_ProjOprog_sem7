﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        return _context.Kurierzy.FirstOrDefault(p=>p.UserId==id);
    }

    public List<DaneKuriera> PobierzListeKurierow()
    { 
        return _context.Kurierzy.Include(p=>p.Samochod).ToList();
    }

    public List<DanePaczki> PobierzListePaczekKuriera(int idKuriera)
    {
        return _context.Paczki.Where(p=>p.Status!=null).Where(p=>p.Status.Kurier!=null).Where(p=>p.Status.Kurier.UserId==idKuriera).ToList();
    }

    public DaneSamochodu PobierzSamochodKuriera(int idKuriera)
    {
      var firstOrDefault = _context.Kurierzy.FirstOrDefault(p => p.UserId == idKuriera);
      return firstOrDefault != null ? firstOrDefault.Samochod : null;
    }

    //TODO: zaimplementoiwać walidację
    public bool WalidujDaneKuriera(DaneKuriera kurier)
    {
      throw new NotImplementedException();
    }
  }
}