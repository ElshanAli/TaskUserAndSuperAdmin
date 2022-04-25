using System;

namespace TaskUserandAdmin
{
    class Program
    {
        static void Main(string[] args)
        {

            User user = new User();
            string username;
            do
            {
                Console.WriteLine("Enter the Username");
                username = Console.ReadLine();
            } while (username.Length<6);
            

            string password;
            do
            {
                Console.WriteLine("Enter the Password");
                password = Console.ReadLine();
            } while (!user.CheckPass(password));
            Console.WriteLine("Enter the Section");
            string section = Console.ReadLine();
            Console.WriteLine("Are you SuperAdmin?");
            string Superadmin = Console.ReadLine();
            bool isSuperAdmin = false;

            if (Superadmin=="yes")
            {
                isSuperAdmin = true;
            }
            else if (Superadmin=="no")
            {
                isSuperAdmin = false;
            }
            Admin admin = new Admin(username, password, section, isSuperAdmin);

            Console.WriteLine(admin.GetInfo());
        }
    }
}
