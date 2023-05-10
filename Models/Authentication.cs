namespace mustyGames.Models
{
    public class Authentication
    {
        public string ErrorMessage { get; set; }
        public bool UsernamePasswordControl(string username, string password)
        {
            if(username == "musty" && password == "games")
                return true;
            else
            {
                ErrorMessage = "Kullanıcı adı veya şifre yanlış!!";
              return false;
            }
                
        }
    }
}
