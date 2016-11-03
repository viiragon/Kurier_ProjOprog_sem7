using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAPSNET.Models
{
    public class DaneUzytkownika
    {
        private int id { get; set; }
        private String imie { get; set; }
        private String nazwisko { get; set; }
        private String login { get; set; }
        private String haslo { get; set; }
        private String adres { get; set; }
        private String uprawnienia { get; set; }

        public DaneUzytkownika(int id, String imie, String nazwisko, String login, String haslo, String adres, String uprawnienia)
        {
            this.id = id;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.login = login;
            this.haslo = haslo;
            this.adres = adres;
            this.uprawnienia = uprawnienia;
        }


    }
}