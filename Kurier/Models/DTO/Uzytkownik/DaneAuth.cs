using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Kurier.Models.DTO.Uzytkownik
{
  public class DaneAuth : IdentityUser
  {

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UserId { get; set; }
    public string Login { get; set; }
    public string Haslo { get; set; }
    public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<DaneAuth> manager, string authenticationType)
    {
      // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
      var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
      // Add custom user claims here
      return userIdentity;
    }
  }
}