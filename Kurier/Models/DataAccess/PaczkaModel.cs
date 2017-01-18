using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Kurier.Interfaces.Model;
using Kurier.Models.Context;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Paczka;
using Kurier.Models.DTO.Uzytkownik;
using System.Text.RegularExpressions;

namespace Kurier.Models.DataAccess
{
  public class PaczkaModel : IMPaczki
  {

    private ApplicationContext _context;

    public PaczkaModel()
    {
      _context = new ApplicationContext();
    }

    public PaczkaModel(ApplicationContext context)
    {
      _context = context;
    }

    public void DodajPaczke(DanePaczki paczka)
    {
      _context.Paczki.Add(paczka);
      _context.SaveChanges();
    }

    public List<DanePaczki> PobierzListePaczek()
    {
      return
        _context.Paczki.Include(p => p.Status)
          .Include(p => p.Adresat)
          .Include(p => p.Nadawca)
          .Include(p => p.Historia)
          .ToList();
    }

    public DanePaczki PobierzPaczke(int id)
    {
      return _context.Paczki.Include(p => p.Status)
          .Include(p => p.Adresat)
          .Include(p => p.Nadawca)
          .Include(p => p.Historia).FirstOrDefault(p => p.Id == id);
    }

    public void PowiazKurieraIPaczke(int idPaczki, int idKuriera)
    {
      DaneKuriera kurier = new KurierzyModel(_context).PobierzKuriera(idKuriera);

      DanePaczki paczka = _context.Paczki.Find(idPaczki);
      if (paczka != null)
        paczka.Status.Kurier = kurier;

      _context.SaveChanges();
    }

    public bool WalidujDanePaczki(DanePaczki paczka)
    {
      return paczka != null && paczka.Adresat != null && WalidujAdres(paczka.Adresat.Adres)
             && paczka.Nadawca != null && WalidujAdres(paczka.Nadawca.Adres);
    }

    private bool WalidujAdres(Adres adres)
    {
      return adres!=null && Regex.IsMatch(adres.KodPocztowy, @"^[0-9]{2}\-[0-9]{3}$")
      && Regex.IsMatch(adres.Miasto, @"^[A-Z][a-z]{2,}$")
      && !string.IsNullOrEmpty(adres.Ulica)
      && !string.IsNullOrEmpty(adres.NumerMieszkania);
    }

    public void ZmienStatusPaczki(Status status, int idPaczki)
    {
      DanePaczki paczka = _context.Paczki.Find(idPaczki);
      if (paczka != null)
      {
        if (paczka.Historia == null)
          paczka.Historia = new List<Status>();
        paczka.Historia.Add(paczka.Status);
        paczka.Status = status;
        _context.SaveChanges();
      }
    }
  }
}