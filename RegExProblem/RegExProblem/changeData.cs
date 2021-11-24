using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegExProblem
{
    class changeData
    {
        public void EditData()
        {
            Console.WriteLine("enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("enter the last name");
            string lastName = Console.ReadLine();
           up1: Console.WriteLine("enter the mobile number");
            string mobileNum = Console.ReadLine();
            if (checkNumber(mobileNum))
            {
                Console.WriteLine("number is updated");
            }
            else
            {
                Console.WriteLine("invalid number");
                goto up1;
            }
           up2: Console.WriteLine("enter the date");
            string date = Console.ReadLine();
            if (checkNumber(mobileNum))
            {
                Console.WriteLine("Date is updated");
            }
            else
            {
                Console.WriteLine("invalid date");
                goto up2;
            }

            Console.WriteLine( "Hello {0},we have your full name as {1} {2} in our system.Please,your contact number is 91-{3}.Please let us know in any type of clerification thank you BridgeLabz {4}",name,name,lastName,mobileNum,date);

        }
        static bool checkNumber(string number)
        {
            string Numreg = @"(^[\d]{10}$)";
            Regex re = new Regex(Numreg);

            if (re.IsMatch(number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool checkDate(string date)
        {
            string Datereg = @"(^[\0-3]{1}[\d]{1}/[\0-1]{1}[0-9]{1}/[\d]{4}$)";
            Regex re = new Regex(Datereg);

            if (re.IsMatch(date))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
