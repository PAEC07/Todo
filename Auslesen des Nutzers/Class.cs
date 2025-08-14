    using System.Security.Principal;

using System.DirectoryServices.AccountManagement;
namespace Todo.Auslesen_des_Nutzers
{

    
    
        public class Auslesen_des_Nutzers
        {


            


            public static string GetUserName()
            {
                string fullUserName = Environment.UserName;

                string[] userParts = fullUserName.Split('\\');

                string userName = userParts.Length > 1 ? userParts[1] : userParts[0];
                return userName;
            }public static string GetUserName1()
            {
            using (PrincipalContext context = new PrincipalContext(ContextType.Domain, Environment.UserDomainName))
            {
                // Benutzerinformationen basierend auf dem aktuellen Benutzernamen abrufen
                UserPrincipal user = UserPrincipal.FindByIdentity(context, Environment.UserName);
            if (user != null)
            {
                    // Vollständigen Namen des Benutzers ausgeben
                    return user.DisplayName;
            }
            else
            {
                Console.WriteLine("Benutzer konnte nicht gefunden werden.");
                    return "Unbekannt";
                }
                }
        }
        }
    }





