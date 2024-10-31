

namespace End_Hw_Week6
{
    public class Authentication : IAuthentication
    {

        public bool Login(string email, string password)
        {
            for (int i = 0; i < Storage.UserCount; i++)
            {
                if (Storage.users[i].Email == email && Storage.users[i].Password == password)
                {
                    Console.WriteLine("Login was successful");
                    return true;
                }
            }
            Console.WriteLine("Invalid username or password");
            return false;

        }

        public void Register(string email, string password, UserRole role)
        {
            for (int i = 0; i < Storage.UserCount; i++)
            {
                if (Storage.UserCount < Storage.users.Length &&( Storage.users[i].Email!=email ) )
                {
                    Storage.users[Storage.UserCount] = new User(email, password, role);
                    Storage.UserCount++;
                    Console.WriteLine("Registration was successful");
                    return;
                }
                else
                {
                    Console.WriteLine("Registration was not successful(because your repeated email!)");
                    return;
                }
            }


        }
    }
}
