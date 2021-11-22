using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace P18._10._2021
{
    public static class Extension
    {
        public static bool IsEmail(this string mail)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(mail);
                return true;
            }
            catch (Exception)
            {

                throw;
                return false;
            }
        }
    }
}
