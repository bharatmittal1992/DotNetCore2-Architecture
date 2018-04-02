using RS.ViewModel.User;

namespace RS.Service.Interfaces
{
    public interface IUserService
    {
        UserViewModel LoginUser(string Email, string Password);

    }
}
