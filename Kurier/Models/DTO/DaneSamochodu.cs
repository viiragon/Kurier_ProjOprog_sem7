using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kurier.Models.DTO
{
  public class DaneSamochodu
  {
    public DaneKuriera DaneKuriera { get; set; }
    public string NumRejestracyjny { get; set; }
    public string Stan { get; set; }
    public int Id { get; set; }
  }
}