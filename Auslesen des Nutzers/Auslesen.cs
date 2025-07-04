using System.Security.Principal;

namespace BlazorApp1.Auslesen_des_Nutzers
{
    public class Auslesen_des_Nutzers
    {
       
        
        protected void addTodo()
        {
            string userName = GetUserName();
            // Hier wird der Benutzername in die Datenbank geschrieben
        }


        public static string GetUserName()
        {
            string fullUserName = Environment.UserName;

            // Teile den Benutzernamen in Domäne und Benutzername auf
            string[] userParts = fullUserName.Split('\\');

            // Wenn der Benutzername das Format "Domäne\Benutzername" hat, nimm den zweiten Teil
            string userName = userParts.Length > 1 ? userParts[1] : userParts[0];
            return userName ;
        }
        }
        }
    


         