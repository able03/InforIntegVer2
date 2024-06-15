using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InforIntegVer2
{
    public class CustomerStaticModel
    {
        private static int id;
        private static string fname;
        private static string mname;
        private static string lname;
        private static string contact;
        private static string email;
        private static string address;
        private static string uname;
        private static string pass;

        public CustomerStaticModel(int id1, string fname1, string mname1, string lname1, string contact1, string email1, string address1, string uname1, string pass1)
        {
            id = id1;
            fname = fname1;
            mname = mname1;
            lname = lname1;
            contact = contact1;
            email = email1;
            address = address1;
            uname = uname1;
            pass = pass1;
        }





        public static int getId(){return id;}
        public static string getfname() { return fname; }
        public static string getmname() {  return mname; }
        public static string getlname() {  return lname; }
        public static string getcontact() { return contact;}
        public static string getemail() { return email;}
        public static string getaddress() { return address;}
        public static string getuname() {  return uname;}
        public static string getpass() { return pass;}
    }
}
