using Models.EFModels;
using Repository.Interfaces;
using System;
using System.Linq;
using System.Windows.Forms;
using WinHogar.Forms;
using WinHogar.Forms.UserForms;
using WinHogar.Utils;
using WinHogar.ViewModels;

namespace WinHogar
{
    public partial class LoginWindow : Form
    {
        private readonly IRepository<User, UserViewModel> _userRepository;
        private readonly IRepository<Country, CountryViewModel> _countryRepository;
        MenuWindow menu;
        public LoginWindow(IRepository<User, UserViewModel> userRepository
            , IRepository<Country, CountryViewModel> countryRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _countryRepository = countryRepository;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EncryptionMethods em = new EncryptionMethods();
            var hashedPassword = em.SHA256_Hash(txtPassword.Text);
            var user = _userRepository.Get(x => x.User1 == txtUserName.Text && x.Password == hashedPassword).FirstOrDefault();

            if (user != null)
            {
                this.Hide();

                menu = new MenuWindow(_userRepository);
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario no existente o password incorrecta");
            }
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            RegisterWindow register = new RegisterWindow(_userRepository, _countryRepository);
            
            register.Show();
        }
    }
}
