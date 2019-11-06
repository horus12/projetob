using System.Net.Mail;

namespace WindowsFormsApp1
{
    public class Email
    {
        public void email_send(string email, string nome){
            MailMessage mail = new MailMessage();
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("projetobsi2019@gmail.com");
            mail.To.Add(email);
            mail.Subject = "Desbloqueio";
            mail.Body = "Olá "+ nome+ " seu usuário foi desbloqueado com sucesso!";
            
            smtpClient.Port = 587;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new System.Net.NetworkCredential("projetobsi2019@gmail.com", "acqe17aA");
            smtpClient.EnableSsl = true;
            smtpClient.Send(mail);

        }
    }
    

}