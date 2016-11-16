using System;
using Kurier.Models.DTO.Uzytkownik;

namespace Kurier.Models.DTO.Paczka
{
  public class Status
  {
    public int Id { get; set; }
    public int KodStatusu { get; set; } 
    public DateTime Czas { get; set; }
    public DaneKuriera Kurier { get; set; }
  
  }
}