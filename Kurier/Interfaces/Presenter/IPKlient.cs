using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurier.Interfaces.Presenter
{
    public interface IPKlient
    {
        void wybranoLogowanieJakoKlient();
        void wybranoNadaniePaczki();
        void wybranoNadaniePaczkiBezLogowania();
        void wybranoRejestracjaJakoKlient();
        void wybranoWylogujKlienta();
        void wybranoZalogujMnieJakoKlient(Models.DTO.Uzytkownik.DaneUzytkownika dane);
        void wybranoZapiszDaneNadanejPaczki(Models.DTO.Paczka.DanePaczki paczka);
        void wybranoZarejestrujMnieJakoKlient(Models.DTO.Uzytkownik.DaneKlienta dane);
    }
}
