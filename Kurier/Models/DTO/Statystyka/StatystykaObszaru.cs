using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Models.DTO.Paczka;


namespace Kurier.Models.DTO.Statystyka
{
  public class StatystykaObszaru
  {
    public List<DaneObszaru> ListaObszarow { get; set; }

    public class DaneObszaru
    {
      public int IloscPaczek { get; set; }
      public string NazwaObszaru { get; set; }
    }
  }
}