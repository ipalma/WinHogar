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

namespace WinHogar.Forms
{
    public partial class MenuWindow : Form
    {
        private readonly IRepository<User, UserViewModel> _userRepository;
        public MenuWindow(IRepository<User, UserViewModel> userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
        }

    }
}
