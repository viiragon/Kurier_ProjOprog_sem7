using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurier.Models.DTO.Statystyka;

namespace Kurier.Interfaces.Model
{
  public interface IMStatystyka
  {

    StatystykaObszaru PobierzNajczestszeObszaryPaczek();

    ObciazenieKurierow PobierzObciazenieKurierow();

    StatystykaKlientow PobierzStatystykeNajczestszychKlientow();

    StatystykaPaczek PobierzStatystykiPaczek();
  }
}
