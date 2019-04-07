using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net.Mime;

namespace Project_Management_Utility_2._0
{
    class Email
    {
        
        public void SendMessage()
        {
            MailMessage m = new MailMessage();
            SmtpClient sc = new SmtpClient();

            m.From = new MailAddress("bignickharper@gmail.com", "Nick Harper");
            m.To.Add(new MailAddress("nickharperdesigns@gmail.com", "Nick Harper Designs, LLC"));
            m.CC.Add(new MailAddress("nicholasharper@protonmail.com", "Nick Harper, Esq."));
            m.Subject = "test";
            m.Body = "this is a test email";

            sc.Host = "smtp.gmail.com";
            sc.Port = 587;
            sc.Credentials = new System.Net.NetworkCredential("bignickharper", "______");
            sc.EnableSsl = true; // runtime encrypt the SMTP communications using SSL
            sc.Send(m);
        }
        
        
    }
}
