using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._17_Friday_Homework
{
    internal class Admin:User
    {
        public string IsSuperAdmin;
        public string Section;

        public Admin(string issuperadmin, string section) 

        {
            
            IsSuperAdmin = issuperadmin;
            Section = section;  
        }
        public string GetAdminData()
        {
            return GetUserInfo()+$" \n IsSuperAdmin: {IsSuperAdmin} \n Section: { Section} ";  
            

        }
    }
}
