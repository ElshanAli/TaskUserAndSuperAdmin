using System;
using System.Collections.Generic;
using System.Text;

namespace TaskUserandAdmin
{
    class Admin:User
    {
        public bool IsSuperAdmin;
        public string Section;

        public Admin(string username,string password,string section,bool issuperadmin):base(username,password)
        {
            IsSuperAdmin = issuperadmin;
            Section = section;
            
        }
        public Admin()
        {

        }

        public string GetInfo()
        {

            return $"Username: {Username} Password: {Password} Section: {Section} IsSuperAdmin: {IsSuperAdmin}";
        }
    }

}
