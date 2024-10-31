
namespace End_Hw_Week6
{
    public interface IAuthentication
    {
        void Register(string email, string password, UserRole role);
        bool Login(string username, string password);
    }
}
