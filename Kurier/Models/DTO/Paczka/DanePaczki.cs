using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Kurier.Models.DTO.Uzytkownik;

namespace Kurier.Models.DTO.Paczka
{
  public class DanePaczki
  {
    public int Id { get; set; }
    public string IdPaczki { get; set; }
    public Adres AdresAdresata { get; set; }
    public DaneUzytkownika Adresat { get; set; }
    public Adres AdresNadawcy { get; set; }
    public DaneUzytkownika Nadawca { get; set; }
    public DateTime? PoczatekObslugi { get; set; }
    public DateTime? KoniecObslugi { get; set; }
    public List<Status> Historia { get; set; }
    public Status Status { get; set; }

    public override bool Equals(object obj)
    {
      DanePaczki danePaczkiObj = obj as DanePaczki;
      if (danePaczkiObj != null)
      {
        return Equals(danePaczkiObj);
      }
      return base.Equals(obj);
    }

    protected bool Equals(DanePaczki other)
    {
      return Id == other.Id && Equals(Nadawca, other.Nadawca) && Equals(Adresat, other.Adresat) && Equals(AdresAdresata, other.AdresAdresata) && PoczatekObslugi.Equals(other.PoczatekObslugi) && KoniecObslugi.Equals(other.KoniecObslugi) && Equals(Historia, other.Historia) && Equals(Status, other.Status);
    }

    public override int GetHashCode()
    {
      unchecked
      {
        var hashCode = Id;
        hashCode = (hashCode * 397) ^ (AdresAdresata != null ? AdresAdresata.GetHashCode() : 0);
        hashCode = (hashCode * 397) ^ PoczatekObslugi.GetHashCode();
        hashCode = (hashCode * 397) ^ KoniecObslugi.GetHashCode();
        hashCode = (hashCode * 397) ^ (Historia != null ? Historia.GetHashCode() : 0);
        hashCode = (hashCode * 397) ^ (Status != null ? Status.GetHashCode() : 0);
        return hashCode;
      }
    }
  }
}