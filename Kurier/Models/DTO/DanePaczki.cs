using System;

namespace Kurier.Models.DTO
{
  public class DanePaczki
  {
    public Adres Adres { get; set; }
    public DateTime PoczatekObslugi { get; set; }
    public DateTime KoniecObslugi { get; set; }
    public Status[] Historia { get; set; }
    public Status Status { get; set; }
  }
}