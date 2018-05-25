using Models.EFModels;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinHogar.ViewModels;

namespace WinHogar
{
    public partial class LoginWindow : Form
    {
        private readonly IRepository<User, UserViewModel> _userRepository;
        MenuWindow menu;
        public LoginWindow(IRepository<User, UserViewModel> userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu = new MenuWindow(_userRepository);
            menu.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterWindow register = new RegisterWindow(_userRepository);
            register.Show();
        }
    }
}
