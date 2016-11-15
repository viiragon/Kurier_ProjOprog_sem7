using System;
using System.Collections.Generic;

namespace Kurier.Models.DTO
{
  public class DanePaczki
  {
    public int Id { get; set; }
    public Adres Adres { get; set; }
    public DateTime PoczatekObslugi { get; set; }
    public DateTime KoniecObslugi { get; set; }
    public List<Status> Historia { get; set; }
    public Status Status { get; set; }
  }
}