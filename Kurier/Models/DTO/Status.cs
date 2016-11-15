using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kurier.Models.DTO
{
  public class Status
  {
    public int Id { get; set; }
    public int KodStatusu { get; set; } 
    public DateTime Czas { get; set; }
    public DaneKuriera Kurier { get; set; }
  
  }
}