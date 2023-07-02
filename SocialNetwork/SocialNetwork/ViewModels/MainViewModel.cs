using SocialNetwork.ViewModels.Account;

namespace SocialNetwork.ViewModels
{
    public class MainViewModel
    {
        public RegisterViewModel RegisterView { get; set; }
        public LoginViewModel LoginView { get; set; }

        public MainViewModel()
        {
            RegisterView = new RegisterViewModel();
            LoginView = new LoginViewModel();
        }
    }
}
