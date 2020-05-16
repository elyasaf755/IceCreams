using System.Security;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModels
{
    /// <summary>
    /// The view model for the login page
    /// </summary>
    public class LoginViewModel : ViewModelBase
    {

        #region Public Properties

        /// <summary>
        /// The email of the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// A flag indicating if the login command is running
        /// </summary>
        public bool IsLoginRunning { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// The command to login
        /// </summary>
        public ICommand LoginCommand { get; set; }

        /// <summary>
        /// The command to change the page to the register page
        /// </summary>
        public ICommand MoveToRegisterPageCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public LoginViewModel()
        {
            // Create commands
            LoginCommand = new RelayParameterizedCommand(async (parameter) => await Login(parameter));
            MoveToRegisterPageCommand = new RelayCommand(async () => await MoveToRegisterPage());
        }

        #endregion

        /// <summary>
        /// Attempts to log the user in
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passed in from the view for the users password</param>
        /// <returns></returns>
        public async Task Login(object parameter)
        {
            await RunCommand(() => this.IsLoginRunning, async () =>
            {
                await Task.Delay(1000);

                var email = this.Email;

                var pass = (parameter as IHavePassword).SecurePassword.Unsecure();

                IoC.Application.GoToPage(ApplicationPage.MainPage);
            });
        }

        /// <summary>
        /// Takes the user to the register page
        /// </summary>
        /// <returns></returns>
        public async Task MoveToRegisterPage()
        {
            // Go to register page?
            IoC.Get<ApplicationViewModel>().CurrentPage = ApplicationPage.RegisterEmail;

            await Task.Delay(1);
        }
    }
}
