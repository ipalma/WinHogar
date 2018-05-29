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
        private readonly IRepository<Income, IncomeViewModel> _incomeRepository;
        private readonly IRepository<IncomeType, IncomeTypeViewModel> _incomeTypeRepo;
        private readonly IRepository<Country, CountryViewModel> _countryRepository;
        private readonly IRepository<TotalAmount, TotalAmountViewModel> _totalAmountRepository;
        MenuWindow menu;
        public LoginWindow(IRepository<User, UserViewModel> userRepository
            , IRepository<Income, IncomeViewModel> incomeRepository
            , IRepository<IncomeType, IncomeTypeViewModel> incomeTypeRepo
            , IRepository<Country, CountryViewModel> countryRepository
            , IRepository<TotalAmount, TotalAmountViewModel> totalAmountRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _incomeRepository = incomeRepository;
            _incomeTypeRepo = incomeTypeRepo;
            _countryRepository = countryRepository;
            _totalAmountRepository = totalAmountRepository;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //EncryptionMethods em = new EncryptionMethods();
            //var hashedPassword = em.SHA256_Hash(txtPassword.Text);
            //var user = _userRepository.Get(x => x.User1 == txtUserName.Text && x.Password == hashedPassword).FirstOrDefault();

            //if (user != null)
            //{
            //    this.Hide();

                menu = new MenuWindow(_userRepository, _incomeRepository, _incomeTypeRepo, _totalAmountRepository);
                menu.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Usuario no existente o password incorrecta");
            //}
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            RegisterWindow register = new RegisterWindow(_userRepository, _countryRepository);
            
            register.Show();
        }
    }
}
