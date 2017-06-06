using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppKurierska.Models
{
    public class NadajPaczkeViewModel
    {
        [Display(Name ="Ulica")]
        public string ulica { get; set; }

        [Display(Name = "Numer domu")]
        public string numerDomu { get; set; }

        [Display(Name = "Kod pocztowy")]
        public string kodPocztowy { get; set; }

        [Display(Name = "Miasto")]
        public string miasto { get; set; }

        [Display(Name = "Region")]
        public string region { get; set; }

        [Display(Name = "Imie")]
        public string imie { get; set; }

        [Display(Name = "Nazwisko")]
        public string nazwisko { get; set; }

        [Display(Name = "Numer telefonu")]
        public string numerTelefonu { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }
    }
}