using System;
using System.Collections.Generic;
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
      return _context.Paczki.ToList();
    }

    public DanePaczki PobierzPaczke(int id)
    {
      return _context.Paczki.FirstOrDefault(p => p.Id == id);
    }

    public void PowiazKurieraIPaczke(int idPaczki, int idKuriera)
    {
      DaneKuriera kurier = new KurierzyModel(_context).PobierzKuriera(idKuriera);

      DanePaczki paczka = _context.Paczki.FirstOrDefault(p => p.Id == idPaczki);
      if (paczka != null)
        paczka.Status.Kurier = kurier;

      _context.SaveChanges();

    }

    public bool WalidujDanePaczki(DanePaczki paczka)
    {
      return WalidujAdres(paczka.Adresat.Adres)
        && WalidujAdres(paczka.Nadawca.Adres);
    }

    private bool WalidujAdres(Adres adres)
    {
      return Regex.IsMatch(adres.KodPocztowy, @"^[0-9]{2}\-[0-9]{3}$")
         && Regex.IsMatch(adres.Miasto, @"^[A-Z][a-z]{2,}$")
         && adres.Ulica.Length > 0
         && adres.NumerMieszkania.Length > 0;
    }

    public void ZmienStatusPaczki(Status status, int idPaczki)
    {
      DanePaczki paczka = _context.Paczki.FirstOrDefault(p => p.Id == idPaczki);
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
