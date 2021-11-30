using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace P11._28._2021
{
    class Student
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Trim().Length>2)
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Get ozune teze ad sec");
                }
            }
        }
        public string Surname { get; set; }
        public string Fullname { get { return Name + " " + Surname; } }
        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                try
                {
                    MailAddress mailAddress = new MailAddress(value);
                    _email = value;
                }
                catch (Exception e)
                {

                    throw e;
                }
            }
        }
    }
}
