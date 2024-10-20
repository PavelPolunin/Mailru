using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Xml.Linq;

namespace Mailru.UsersClasses
{
    public abstract class InfoEmail
    {
        private string _smtpClientAdress;
        private StringPair _emailAdressFrom;
        private string _emailPassword;
        private StringPair _emailAdressTo;
        private string _subject;
        private string _body;
        private int _port;
        public InfoEmail(string smtpClientAdress,
        StringPair emailAdressFrom,
        string emailPassword,
        StringPair emailAdressTo,
        string subject,
        string body)
        {
            SmtpClientAdress = String.IsNullOrWhiteSpace(smtpClientAdress) ?
            throw new Exception("Нельзя вставлять пробелы или пустое значение!") :
            smtpClientAdress;

            EmailAdressFrom = emailAdressFrom ?? throw new ArgumentNullException(nameof(emailAdressFrom));

            EmailPassword = String.IsNullOrWhiteSpace(emailPassword) ?
            throw new Exception("Нельзя вставлять пробелы или пустое значение!") :
            emailPassword;

            EmailAdressTo = emailAdressTo ?? throw new ArgumentNullException(nameof(emailAdressTo));

            Subject = subject ?? throw new ArgumentNullException(nameof(subject));

            Body = body ?? throw new ArgumentNullException(nameof(body));
        }
        public string SmtpClientAdress
        {
            get { return _smtpClientAdress; }
            set
            {
                _smtpClientAdress = String.IsNullOrWhiteSpace(value) ?
                    throw new ArgumentException(nameof(_smtpClientAdress)) :
                    value;
            }
        }
        public StringPair EmailAdressFrom
        {
            get { return _emailAdressFrom; }
            set
            {
                _emailAdressFrom = value ??
                    throw new ArgumentNullException(nameof(_emailAdressFrom));
            }
        }
        public string EmailPassword 
        {
            get { return _emailPassword; }
            set
            {
                _emailPassword = String.IsNullOrWhiteSpace(value) ?
                    throw new ArgumentException(nameof(_emailPassword)) :
                    value;
            }
        }
        public StringPair EmailAdressTo
        {
            get { return _emailAdressTo; }
            set
            {
                _emailAdressTo = value ??
                    throw new ArgumentNullException(nameof(_emailAdressTo));
            }
        }
            
        public string Subject
        {
            get { return _subject; }
            set
            {
                _emailPassword = String.IsNullOrWhiteSpace(value) ?
                    throw new ArgumentException(nameof(_subject)) :
                    value;
            }
        }
            
        public string Body
        {
            get { return _body; }
            set
            {
                _emailPassword = String.IsNullOrWhiteSpace(value) ?
                    throw new ArgumentException(nameof(value)) :
                    value;
            }
        }
        public int Port
        {
            get { return _port; }
            set { _port = value; }
        }
        protected InfoEmail(StringPair emailAdressTo, string subject, string body)
        {
            EmailAdressTo = emailAdressTo;
            Subject = subject;
            Body = body;
        }
    }


        public class StringPair
        {
            public StringPair(string emailAdress, string name)
            {
                EmailAdress = String.IsNullOrWhiteSpace(emailAdress) ?
                throw new Exception("Нельзя вставлять пробелы или пустрое значение!") :
                emailAdress;

                Name = String.IsNullOrWhiteSpace(name) ?
                throw new Exception("Нельзя вставлять пробелы или пустрое значение!") :
                name;
            }

            public string EmailAdress { get; set; }
            public string Name { get; set; }
        }
}
