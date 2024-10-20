using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mailru.UsersClasses
{
    public class InfoMailRu : InfoEmail
    {
        public InfoMailRu(StringPair emailAdressTo, string subject, string body)
            : base(emailAdressTo, subject, body)
        {
            SmtpClientAdress = " smtp.mail.ru";
            EmailAdressFrom = new StringPair(" почта mail", "ФИО Студента"); 
            EmailPassword = "nароль";
            Port = -1;

        }
    }
}
