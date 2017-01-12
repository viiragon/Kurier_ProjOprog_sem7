using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Providers.Entities;
using Kurier.Interfaces.Model;
using Kurier.Models.Context;
using Kurier.Models.DTO.Paczka;
using Kurier.Models.DTO.Statystyka;
using Kurier.Models.DTO.Uzytkownik;
using Kurier.Presenters.CentralaManager.KurierzyCM;
using Kurier.Presenters.CentralaManager.PaczkiCM;
using DaneStatystykiKlienta = Kurier.Models.DTO.Statystyka.StatystykaKlientow.DaneStatystykiKlienta;
using StatystykaKuriera = Kurier.Models.DTO.Statystyka.ObciazenieKurierow.StatystykaKuriera;
using DaneObszaru = Kurier.Models.DTO.Statystyka.StatystykaObszaru.DaneObszaru;

namespace Kurier.Models.DataAccess
{
  public class StatystykiModel : IMStatystyka
  {

      public StatystykaObszaru PobierzNajczestszeObszaryPaczek()
      {
          return new StatystykaObszaru()
              {
                  ListaObszarow = new ApplicationContext().Paczki.ToList().Where(p => p.AdresAdresata != null)
                .Select(p => p.AdresAdresata.Miasto)
                .GroupBy(p => p, q => q)
                .Select(p => new DaneObszaru() { NazwaObszaru = p.Key, IloscPaczek = p.Count() })
                .ToList()
              };
      }
    public ObciazenieKurierow PobierzObciazenieKurierow()
    {
      ObciazenieKurierow obciazenieKurierow = new ObciazenieKurierow
      {
        ListaKurierow = new ApplicationContext().Kurierzy.Select(
          p => new StatystykaKuriera() {Kurier = p, PrzypisanePaczki = new List<DanePaczki>()}).ToList()
      };

      List<DanePaczki> listaPaczek =
        new ApplicationContext().Paczki.Include(p => p.Status)
          .Include(p => p.Status.Kurier)
          .Where(p => p.Status != null && p.Status.Kurier != null)
          .ToList();

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
      StatystykaKlientow statystykaKlientow = new StatystykaKlientow
      {
        StatystykiKlienta =
          new ApplicationContext().Klienci.Select(p => new DaneStatystykiKlienta() {DaneKlienta = p}).ToList()
      };

      List<DanePaczki> paczki =
        new ApplicationContext().Paczki.Include(p => p.Adresat)
          .Include(p => p.Nadawca)
          .Where(p => p.Adresat != null || p.Nadawca != null)
          .ToList();

      foreach (var paczka in paczki)
      {
        DaneStatystykiKlienta daneStatystykiKlienta =
          statystykaKlientow.StatystykiKlienta.FirstOrDefault(p => KlientMaPowiazanieZPaczka(paczka, p.DaneKlienta));
        if (daneStatystykiKlienta != null) daneStatystykiKlienta.LiczbaPaczek++;
      }

      return statystykaKlientow;
    }

    private bool KlientMaPowiazanieZPaczka(DanePaczki paczka, DaneAuth daneKlienta)
    {
      return paczka.Adresat != null && daneKlienta.UserId == paczka.Adresat.UserId
             || paczka.Nadawca != null && daneKlienta.UserId == paczka.Nadawca.UserId;
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