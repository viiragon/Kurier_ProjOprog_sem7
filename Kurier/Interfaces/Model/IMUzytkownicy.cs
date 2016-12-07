using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Uzytkownik;

namespace Kurier.Interfaces.Model
{
  public interface IMUzytkownicy
  {
    void ZalogujDoCentrali(DaneAuthUzytkownika dane);
    void ZalogujJakoKlient(DaneAuthKlienta dane);
    void ZalogujJakoKurier(DaneAuthKuriera dane);
    void ZarejestrujJakoKlient(DaneKlienta dane);
    bool CzyIstniejeUzytkonik(string username);
  }
}
