//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Text.RegularExpressions;

//namespace Hotel.Core.Helpers
//{
//    public class Validation
//    {
//        public static bool CheckEmail(string email)
//        {
//            string strRegex = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
//            return PerformRegEx(strRegex, email);
//        }

        
//        public static bool CheckPassword(string password)
//        {

//            string strRegex = @"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{6,}$";
//            return PerformRegEx(strRegex, password);
//        }

//        private static bool PerformRegEx(string pattern, string value)
//        {
//            Regex re = new Regex(pattern);


//            if (re.IsMatch(value))
//                return (true);
//            else
//                return (false);
//        }
//    }
//}
