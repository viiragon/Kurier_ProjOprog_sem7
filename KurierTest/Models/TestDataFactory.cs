using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Paczka;
using Kurier.Models.DTO.Samochod;
using Kurier.Models.DTO.Uzytkownik;

namespace KurierTest.Models
{
  class TestDataFactory
  {
    public static DaneSamochodu Samochod = new DaneSamochodu()
    {
      Id = 5,
      NumRejestracyjny = "WTS9231",
      Stan = "sprawny"
    };

    #region TestKurierData

    public static DaneKuriera DaneKuriera => new DaneKuriera()
    {
      Adres = new Adres()
      {
        KodPocztowy = "44-44",
        Miasto = "Sierpc",
        NumerMieszkania = "2",
        Ulica = "Poniatowskiego"
      },
      Nazwisko = "Mirosławski",
      Imie = "Stanisław",
      NumerPracowanika = 100,
      UserId = 10
    };

    public static DaneKuriera DaneKuriera1 => new DaneKuriera()
    {
      Adres = new Adres()
      {
        KodPocztowy = "09-201",
        Miasto = "Sierpc",
        NumerMieszkania = "2",
        Ulica = "Poniatowskiego"
      },
      Nazwisko = "Kowalski",
      Imie = "Maciej",
      UserId = 3,
      Samochod = Samochod
    };

    public static DaneKuriera DaneKuriera2 => new DaneKuriera()
    {
      Imie = "Krystian",
      Nazwisko = "Nowakowski",
      Adres = new Adres()
      {
        KodPocztowy = "29-120",
        Miasto = "Kluczewsko",
        NumerMieszkania = "12",
        Ulica = "Spółdzielcza"
      },
            UserId = 4,

    };
    #endregion
    #region PaczkaTestData

    public static DanePaczki Paczka1 => new DanePaczki()
    {
      AdresAdresata = new Adres()
      {
        KodPocztowy = "29-120",
        Miasto = "Kluczewsko",
        NumerMieszkania = "12",
        Ulica = "Spółdzielcza"
      },
      Status = new Status() { Kurier = DaneKuriera1, Czas = new DateTime(1990, 10, 11) }
  ,
      PoczatekObslugi = new DateTime(1990, 10, 10),
      KoniecObslugi = new DateTime(1990, 10, 12)
    };

    public static DanePaczki Paczka2 => new DanePaczki()
    {
      AdresAdresata = new Adres()
      {
        Ulica = "Niebieska",
        KodPocztowy = "01-999",
        Miasto = "Białe Trzecie",
        NumerMieszkania = "139"
      }
      ,
      PoczatekObslugi = new DateTime(1990, 10, 10),
      KoniecObslugi = new DateTime(1990, 10, 12)
    };

    #endregion

  }
}
