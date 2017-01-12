using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurier.Models.Context;
using Kurier.Models.DTO.Paczka;
using Kurier.Models.DTO.Samochod;
using Kurier.Models.DTO.Uzytkownik;
using Moq;

namespace KurierTest.Models
{
  class MockMainteiner
  {
    public static ApplicationContext PobierzContextPaczek(List<DanePaczki> paczki)
    {
      DbSet<DanePaczki> mockDbSet = StworzMockBazy(paczki).Object;
      Mock<ApplicationContext> applicationContext = new Mock<ApplicationContext>();
      applicationContext.Setup(p => p.Paczki).Returns(mockDbSet);
      return applicationContext.Object;
    }

    public static ApplicationContext PobierzContextKurierow(List<DaneKuriera> kurierzy, List<DaneSamochodu> samochody = null, List<DanePaczki> paczki = null)
    {

      DbSet<DaneKuriera> mockDbSet = StworzMockBazy(kurierzy).Object;
      Mock<ApplicationContext> userContext = new Mock<ApplicationContext>();
      userContext.Setup(p => p.Kurierzy).Returns(mockDbSet);
      if (samochody != null)
      {
        DbSet<DaneSamochodu> mockDbSetSamochodow = StworzMockBazy(samochody).Object;
        userContext.Setup(p => p.Samochody).Returns(mockDbSetSamochodow);
      }
      if (paczki != null)
      {
        DbSet<DanePaczki> mockDbSetPaczek = StworzMockBazy(paczki).Object;
        userContext.Setup(p => p.Paczki).Returns(mockDbSetPaczek);
      }
      return userContext.Object;
    }

    public static ApplicationContext PobierzContextSamochodow(List<DaneSamochodu> samochody)
    {
      Mock<DbSet<DaneSamochodu>> mockDbSet = StworzMockBazy(samochody);

      Mock<ApplicationContext> applicationContext = new Mock<ApplicationContext>();
      applicationContext.Setup(p => p.Samochody).Returns(mockDbSet.Object);
      return applicationContext.Object;
    }

    private static Mock<DbSet<T>> StworzMockBazy<T>(List<T> elements) where T : class
    {
      IQueryable<T> elementsAsQueryable = elements.AsQueryable();
      Mock<DbSet<T>> dbSetMock = new Mock<DbSet<T>>();

      dbSetMock.As<IQueryable<T>>().Setup(m => m.Provider).Returns(elementsAsQueryable.Provider);
      dbSetMock.As<IQueryable<T>>().Setup(m => m.Expression).Returns(elementsAsQueryable.Expression);
      dbSetMock.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(elementsAsQueryable.ElementType);
      dbSetMock.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(elementsAsQueryable.GetEnumerator());
      dbSetMock.Setup(m => m.Include(It.IsAny<string>())).Returns(dbSetMock.Object);
      dbSetMock.Setup(m => m.Add(It.IsAny<T>())).Callback<T>(elements.Add);
      dbSetMock.Setup(m => m.Remove(It.IsAny<T>())).Returns<T>(p => RemovingMock(p, elements));

      dbSetMock.Setup(x => x.Find(It.IsAny<object[]>())).Returns<object[]>(x => elements.FirstOrDefault(p => GetIdOfSpecyficType(p) == (int)x[0]) as T);

      return dbSetMock;
    }

    private static T RemovingMock<T>(T element, List<T> elementList)
    {
      elementList.Remove(element);
      return element;
    }

    //tylko na potrzeby testowania
    //TODO zdefiniować interfejs lub poszukać rozwiązania związanego z entity frameworkiem
    private static int GetIdOfSpecyficType(object value)
    {
      if (value is DaneSamochodu)
        return (value as DaneSamochodu).Id;
      if (value is DaneKuriera)
        return (value as DaneKuriera).UserId;
      if (value is DanePaczki)
        return (value as DanePaczki).Id;
      throw new NotImplementedException();
    }
  }
}
