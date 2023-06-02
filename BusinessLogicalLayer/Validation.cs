using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using System.Text.RegularExpressions;
namespace BusinessLogicalLayer
{
   public class Validation
    {

        string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
//------------------------------ Check Valid Nick Name----------------------------//

       public static bool isValidNickName(string name)
       {
           {
               name = name.Trim();
               string[] nameWithOutSpace = name.Split(' ');
               string fullName = string.Empty;
               foreach (string na in nameWithOutSpace)
               {
                   fullName += na;

               }

               int count = 0;
               int length = fullName.Length;
               foreach (char ch in fullName)
               {
                   if (char.IsLetter(ch))
                   {
                       count++;
                   }

               }
               if (count == length)
               {
                   return true;
               }
               else
                   return false;
           }
       }


//------------------------------ Check Vaild Name----------------------------------//

       public static bool isValidName(string name)
       {
           
           foreach (char c in name)
           {
               if (!(char.IsLetter(c)||c==' '))
               {
                   return false;
               }
              
           }
           return true;
       }


//--------------------------------Check Valid UserName------------------------------//

       public static bool isValidUserName(string username)
       {
           foreach (char c in username)
           {
               if(!(char.IsLetterOrDigit(c)))
               {
                   return false;
               }
           }
           return true;
       }
     

//--------------------------------Check Valid Salary-----------------------------------//

        public static bool isValidSalary(long salary)
        {
            if (salary <= 0)
            {
                return false;
            }
            return true;
        }


//---------------------------------Check Valid Password--------------------------------//

       //public static bool isValidPassword(string password)
       // {

       //     if (!(password.Contains("@")))
       //     {
       //         return false;
       //     }


       //     return true;
       // }

        //----------------Check Valid Password------------//

        public string isValidPassword()
        {
            string ErrorMessage; ;
            var input = Password;
            //ErrorMessage = string.Empty;

           

            var hasNumber = new Regex(@"[0-9]+");
            //var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (string.IsNullOrWhiteSpace(input))
            {
                ErrorMessage = ("Password should not be empty");
            }
            else if (!hasLowerChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain at least one lower case letter.";

            }
            
            //else if (!hasUpperChar.IsMatch(input))
            //{
            //    ErrorMessage = "Password should contain at least one upper case letter.";

            //}
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                ErrorMessage = "Password should not be lesser than 8 or greater than 15 characters.";

            }
            else if (!hasNumber.IsMatch(input))
            {
                ErrorMessage = "Password should contain at least one numeric value.";

            }

            else if (!hasSymbols.IsMatch(input))
            {
                ErrorMessage = "Password should contain at least one special case character.";

            }
            else
            {
                ErrorMessage = "";
            }
            return ErrorMessage;

        }
//--------------------------------Check Valid Phone Number------------------------------//

        public static bool isValidAPhoneNumber(string number)
        {
            number = number.Trim();
            string[] nameWithOutSpace = number.Split(' ');
            string phNumber = string.Empty;
            foreach (string na in nameWithOutSpace)
            {
                phNumber += na;

            }

            int count = 0;
            int length = phNumber.Length;
            foreach (char ch in phNumber)
            {
                if (char.IsNumber(ch))
                {
                    count++;
                }

            }
            if (count == length&&number.Length==10)
            {
                return true;
            }
            else
                return false;
        }


//-------------------------------Check Valid Aadhar Number-------------------------------//

        public static bool isValidAddhar(string number)
        {
            number = number.Trim();
            string[] nameWithOutSpace = number.Split(' ');
            string addharNumber = string.Empty;
            foreach (string na in nameWithOutSpace)
            {
                addharNumber += na;

            }

            int count = 0;
            int length = addharNumber.Length;
            foreach (char ch in addharNumber)
            {
                if (char.IsNumber(ch))
                {
                    count++;
                }

            }
            if (count == length && number.Length == 12)
            {
                return true;
            }
            else
                return false;
        }


//-------------------------------Check Valid Weight-------------------------------//

        public static bool isValidWeight(string weight)
        {
            foreach (char c in weight)
            {
                if (!(char.IsLetterOrDigit(c) || c == ' '))
                {
                    return false;
                }
            }
            return true;
        }




//---------------------------------- Amount---------------------------------------//
     
       string _amount;

        public string Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

       // Valid Amount
        public bool isValidAmount()
        {
            int count = 0;
            foreach (char c in Amount)
            {
                if (char.IsNumber(c))
                {
                    count++;
                }

            }
            if (count == Amount.Length)
            {
                return true;
            }
            else
                return false;
        }


//-----------------------------  Payment Amount------------------------------//

        public bool isValidPaymentAmount(string PaidAmount)
        {
            int amount = 0;
            int paidAmount = 0;
            bool a = int.TryParse(Amount, out amount);
            bool pa = int.TryParse(PaidAmount, out paidAmount);
            int count = 0;
            foreach (char n in PaidAmount)
            {
                if (char.IsNumber(n))
                {
                    count++;
                }

            }
            if (count == PaidAmount.Length && amount >= paidAmount)
            {
                return true;
            }
            else
                return false;

        }


//--------------------------------Others Purpose------------------------------------------//

       public static bool  isValidPurpose(string Purpose)
       {
           Purpose.Trim();
           string [] PurposeType=Purpose.Split();
           string EnterPurposeType=string .Empty;
           foreach(string purpose in PurposeType)
           {
               EnterPurposeType +=purpose;
           }
            int count = 0;
               int length = EnterPurposeType.Length;
               foreach (char ch in EnterPurposeType)
               {
                   if (char.IsLetter(ch))
                   {
                       count++;
                   }

               }
               if (count == length)
               {
                   return true;
               }
               else
                   return false;

       }
    }
}

