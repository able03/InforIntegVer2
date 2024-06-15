using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InforIntegVer2
{
    public  class AdminStaticClass
    {
        private static int id;
        private static string uname;
        private static string password;
        private static int level;

        public AdminStaticClass(int id1, string uname1, string pass1, int level1)
        {
            id = id1;
            uname = uname1; 
            password = pass1;   
            level = level1;
        }

        public static int getId() { return id; }
        public static string getUname() {  return uname; }
        public static string getPassword() { return password;}
        public static int getLevel() { return level;}
    }
}
