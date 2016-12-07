﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using Kurier.Interfaces.Model;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Uzytkownik;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;


namespace Kurier.Models.DataAccess
{
  public class UzytkownicyModel : IMUzytkownicy
  {

    public void ZalogujDoCentrali(DaneAuthUzytkownika dane)
    {
      var user = GetUser(dane.Login, dane.Haslo);
      SignIn(user);
    }


    public void ZalogujJakoKlient(DaneAuthKlienta dane)
    {
      var user = GetUser(dane.Login, dane.Haslo);
      SignIn(user);
    }

    public void ZalogujJakoKurier(DaneAuthKuriera dane)
    {
      var user = GetUser(dane.Login, dane.Haslo);
      SignIn(user);

    }

    public void ZarejestrujJakoKlient(DaneKlienta dane)
    {
      var user = GetUser(dane.Login, dane.Haslo);
      SignIn(user);
    }
    private IdentityUser GetUser(string login, string password)
    {
      var userStore = new UserStore<IdentityUser>();
      var userManager = new UserManager<IdentityUser>(userStore);
      return userManager.Find(login, password);
    }

    private void SignIn(IdentityUser user)
    {

      if (user != null)
      {
        var userStore = new UserStore<IdentityUser>();
        var userManager = new UserManager<IdentityUser>(userStore);

        var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
        var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
        authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false }, userIdentity);
      }

    }
    protected void SignOut()
    {
      var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
      authenticationManager.SignOut();
    }


  }
}