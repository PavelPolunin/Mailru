using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mailru.UsersClasses
{
    public class InfoGMail : InfoEmail
    {
        public InfoGMail(StringPair emailAdressTo, string subject, string body)
            : base(emailAdressTo, subject, body)
        {
            SmtpClientAdress = " smtp.gmail.com ";
            EmailAdressFrom = new StringPair("почта@ gmail.com ", "ФИО Студента"); 
            EmailPassword = "пароль";
            Port = 587;
        }
    }
}
