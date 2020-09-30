using System.Text.RegularExpressions;

namespace PMS.Keys
{
    public static class Validation
    {
        public static bool Emailvalidation(string EmailId)
        {
            bool IsValid = false;
            if (!string.IsNullOrEmpty(EmailId))
            {
               
                string emailRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                Regex re = new Regex(emailRegex);
                if (!re.IsMatch(EmailId))
                {
                    IsValid = true;
                }
            }
            return IsValid;
        }
    }
}
