using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using Microsoft.Extensions.Hosting;


namespace mustyGames.Controllers
{
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
			string? message = TempData["Message"] as string;
			ViewBag.Message = message;
			return View();
        }
        [HttpPost]
        public ActionResult Index(string name, string email, string subject, string message)
        {



            // E-posta göndermek için SMTP ayarlarını yapılandırın
            SmtpClient smtpClient = new SmtpClient("smtp.office365.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new System.Net.NetworkCredential("cakirmmustafa3@outlook.com", "195957Mu*"); // Mesaj gönder

            // Posta mesajını oluştur
                            MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("cakirmmustafa3@outlook.com");
                mailMessage.To.Add("cakirmmustafa3@outlook.com"); //Mesaj al
                mailMessage.Subject = subject;
                mailMessage.Body = message;

            // Posta iletisini SMTP sunucusuna gönder
            smtpClient.Send(mailMessage);


			// Kullanıcıyı başarıyla gönderilen sayfaya yönlendir			
			 return RedirectToAction("Send");






        }
        public ActionResult Send()
        {
            return View();
        }

    }

}
