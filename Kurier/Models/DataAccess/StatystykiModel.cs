using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Interfaces.Model;
using Kurier.Models.Context;
using Kurier.Models.DTO.Paczka;
using Kurier.Models.DTO.Statystyka;
using Kurier.Models.DTO.Uzytkownik;
using Kurier.Presenters.CentralaManager.PaczkiCM;

namespace Kurier.Models.DataAccess
{
  public class StatystykiModel : IMStatystyka
  {
    public StatystykaObszaru PobierzNajczestszeObszaryPaczek()
    {
      throw new NotImplementedException();
    }

    public ObciazenieKurierow PobierzObciazenieKurierow()
    {
      ObciazenieKurierow obciazenieKurierow = new ObciazenieKurierow();
      List<DaneKuriera> listaKurierow = new ApplicationContext().Kurierzy.ToList();
      obciazenieKurierow.ListaKurierow.AddRange(
        listaKurierow.Select(
          p => new ObciazenieKurierow.StatystykaKuriera() {Kurier = p, PrzypisanePaczki = new List<DanePaczki>()}));

      List<DanePaczki> listaPaczek =
        new ApplicationContext().Paczki.Where(p => p.Status != null && p.Status.Kurier != null).ToList();

      foreach (var danePaczki in listaPaczek)
      {
        ObciazenieKurierow.StatystykaKuriera statystykaKuriera =
          obciazenieKurierow.ListaKurierow.FirstOrDefault(p => p.Kurier.UserId == danePaczki.Status.Kurier.UserId);
        if (statystykaKuriera != null) statystykaKuriera.PrzypisanePaczki.Add(danePaczki);
      }
      obciazenieKurierow.ListaKurierow.ForEach(p => p.IloscPaczek = p.PrzypisanePaczki.Count);

      return obciazenieKurierow;
    }

    public StatystykaKlientow PobierzStatystykeNajczestszychKlientow()
    {
      throw new NotImplementedException();
    }

    public StatystykaPaczek PobierzStatystykiPaczek()
    {
      int liczbaPaczekWDrodze = new ApplicationContext().Paczki.Count(
        p => p.Status != null && p.Status.KodStatusu == (int) StatusEnum.WDrodze && p.Status.Kurier != null);
      int liczbaKurierowRozwazacychPaczki =
        new ApplicationContext().Paczki.Where(p => p.Status != null).Select(p => p.Status.Kurier).Distinct().Count();
      int sredniaLiczbaPaczekNaKuriera = liczbaPaczekWDrodze / liczbaKurierowRozwazacychPaczki;

      return new StatystykaPaczek()
      {
        LiczbaDostarczonychPaczek =
          new ApplicationContext().Paczki.Count(
            p => p.Status != null && p.Status.KodStatusu == (int) StatusEnum.Doreczona),
        LiczbaNadanychPaczek =
          new ApplicationContext().Paczki.Count(p => p.Status != null && p.Status.KodStatusu == (int) StatusEnum.Nadana),
        SredniaLiczbaPaczekNaKuriera = sredniaLiczbaPaczekNaKuriera
      };
    }
  }
}