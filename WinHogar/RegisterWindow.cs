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
    public partial class RegisterWindow : Form
    {
        private readonly IRepository<User, UserViewModel> _userRepository;
        public RegisterWindow(IRepository<User, UserViewModel> userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new UserViewModel()
                {
                    User1 = txtUserName.Text,
                    Password = txtPassword.Text,
                    FirstName = txtFirstName.Text,
                    MiddleName = string.IsNullOrEmpty(txtMiddleName.Text) ? null : txtMiddleName.Text,
                    LastName = txtLastName.Text,
                    SecondLastName = string.IsNullOrEmpty(txtSecondLastName.Text) ? null : txtSecondLastName.Text,
                    IdentityNumber = txtIdentityNumber.Text,
                    BirthDate = DateTime.Parse(txtBirthDate.Text),
                    Email = txtEmail.Text,
                    rowguid = Guid.NewGuid(),
                    Nationality = Convert.ToInt32(txtNationality.Text),
                    CreateDate = dtpCreateDate.Value,
                    ModifiedDate = dtpModifiedDate.Value

                };

                _userRepository.Add(user);

                MessageBox.Show("User {0} has been created", user.FirstName);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
