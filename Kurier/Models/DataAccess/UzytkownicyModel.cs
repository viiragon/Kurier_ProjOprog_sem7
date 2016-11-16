using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Interfaces.Model;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Uzytkownik;

namespace Kurier.Models.DataAccess
{
  public class UzytkownicyModel : IMUzytkownicy
  {
    public void ZalogujDoCentrali(DaneAuthUzytkownika dane)
    {
      throw new NotImplementedException();
    }

    public void ZalogujJakoKlient(DaneAuthKlienta dane)
    {
      throw new NotImplementedException();
    }

    public void ZalogujJakoKurier(DaneAuthKuriera dane)
    {
      throw new NotImplementedException();
    }

    public void ZarejestrujJakoKlient(DaneKlienta dane)
    {
      throw new NotImplementedException();
    }
  }
}