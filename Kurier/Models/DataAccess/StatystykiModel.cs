using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Interfaces.Model;
using Kurier.Models.DTO.Statystyka;

namespace Kurier.Models.DataAccess
{
    public class StatystykiModel : IMStatystyka
    {
        public StatystykaObszaru PobierzNajczestszeObszaryPaczek()
        {
            throw new NotImplementedException();
        }

        public ObciazenieKurierow PobierzObciazenieKurierow()
        {
            throw new NotImplementedException();
        }

        public StatystykaKlientow PobierzStatystykeNajczestszychKlientow()
        {
            throw new NotImplementedException();
        }

        public StatystykaPaczek PobierzStatystykiPaczek()
        {
            throw new NotImplementedException();
        }
    }
}