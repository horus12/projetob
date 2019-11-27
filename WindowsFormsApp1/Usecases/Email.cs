using System.Net.Mail;

namespace WindowsFormsApp1
{
    public class Email
    {
        public void email_send(string email, string subject,string file,string body){
            MailMessage mail = new MailMessage();
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("projetobsi2019@gmail.com");
            mail.To.Add(email);
            mail.Subject = subject;
            mail.Body = body;

            if (!file.Equals(""))
            {
                Attachment attachment;
                attachment = new Attachment(file);
                mail.Attachments.Add(attachment);
            }

            
            smtpClient.Port = 587;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new System.Net.NetworkCredential("projetobsi2019@gmail.com", "acqe17aA");
            smtpClient.EnableSsl = true; 
            smtpClient.Send(mail);

        }
    }
    

}