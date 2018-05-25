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
    public partial class MenuWindow : Form
    {
        private readonly IRepository<User, UserViewModel> _userRepository;
        public MenuWindow(IRepository<User, UserViewModel> userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            LoadDataInfo();
        }

        public void LoadDataInfo()
        {
            DateTime now = DateTime.Now;
            var user = _userRepository.Get(1);
            lblName.Text = string.Concat(user.FirstName, !string.IsNullOrEmpty(user.MiddleName) ? " " + user.MiddleName + " " : string.Empty, " ", user.LastName, !string.IsNullOrEmpty(user.SecondLastName) ? " " + user.SecondLastName : string.Empty, ".");
            lbl3.Text = string.Format("Son las {0}:{1}:{2} del día {3}/{4}/{5}", now.Hour, now.Minute, now.Second, now.Day, now.Month, now.Year);
        }
    }
}
