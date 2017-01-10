﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Interfaces.Model;
using Kurier.Models.Context;
using Kurier.Models.DTO.Paczka;
using Kurier.Models.DTO.Statystyka;

namespace Kurier.Models.DataAccess
{
  public class StatystykaModel : IMStatystyka
  {
    public StatystykaObszaru PobierzNajczestszeObszaryPaczek()
    {
      throw new NotImplementedException();
    }

    public ObciazenieKurierow PobierzObciazenieKurierow()
    {
      throw new NotImplementedException();
    }

    public StatystykaKlientow PobierzStatystykeNajczestszychKlientow()
    {
      throw new NotImplementedException();
    }

    public StatystykaPaczek PobierzStatystykiPaczek()
    {
      int liczbaPaczekWDrodze = new ApplicationContext().Paczki.Count(
        p => p.Status.KodStatusu == (int)StatusEnum.WDrodze && p.Status.Kurier != null);
      int liczbaKurierowRozwazacychPaczki = new ApplicationContext().Paczki.Select(p => p.Status.Kurier).Distinct().Count();
      int sredniaLiczbaPaczekNaKuriera = liczbaPaczekWDrodze/liczbaKurierowRozwazacychPaczki;

      return new StatystykaPaczek()
      {
        LiczbaDostarczonychPaczek = new ApplicationContext().Paczki.Count(p => p.Status.KodStatusu == (int)StatusEnum.Doreczona),
        LiczbaNadanychPaczek = new ApplicationContext().Paczki.Count(p => p.Status.KodStatusu == (int)StatusEnum.Nadana),
        SredniaLiczbaPaczekNaKuriera = sredniaLiczbaPaczekNaKuriera
      };
    }
  }
}