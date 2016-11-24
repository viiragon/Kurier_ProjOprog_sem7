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
      //Todo zaimplementować autoryzację
      //throw new NotImplementedException();
    }

    public void ZalogujJakoKlient(DaneAuthKlienta dane)
    {
      //Todo zaimplementować autoryzację
      //throw new NotImplementedException();
    }

    public void ZalogujJakoKurier(DaneAuthKuriera dane)
    {
      //Todo zaimplementować autoryzację
      //throw new NotImplementedException();
    }

    public void ZarejestrujJakoKlient(DaneKlienta dane)
    {
      //Todo zaimplementować autoryzację
      //throw new NotImplementedException();
    }
  }
}