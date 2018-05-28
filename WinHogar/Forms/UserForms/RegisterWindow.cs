using Models.EFModels;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinHogar.Utils;
using WinHogar.ViewModels;

namespace WinHogar.Forms.UserForms
{
    public partial class RegisterWindow : Form
    {
        private readonly IRepository<User, UserViewModel> _userRepository;
        private readonly IRepository<Country, CountryViewModel> _countryRepository;
        public RegisterWindow(IRepository<User, UserViewModel> userRepository
            , IRepository<Country, CountryViewModel> countryRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _countryRepository = countryRepository;
            LoadDropdownCountries();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                EncryptionMethods em = new EncryptionMethods();
                var hashedPassword = em.SHA256_Hash(txtPassword.Text);

                var user = new UserViewModel()
                {
                    User1 = txtUserName.Text,
                    Password = hashedPassword,
                    FirstName = txtFirstName.Text,
                    MiddleName = string.IsNullOrEmpty(txtMiddleName.Text) ? null : txtMiddleName.Text,
                    LastName = txtLastName.Text,
                    SecondLastName = string.IsNullOrEmpty(txtSecondLastName.Text) ? null : txtSecondLastName.Text,
                    IdentityNumber = txtIdentityNumber.Text,
                    BirthDate = dtpBirthDate.Value,
                    Email = txtEmail.Text,
                    rowguid = Guid.NewGuid(),
                    Nationality = Convert.ToInt32(cbCountries.SelectedValue),
                    CreateDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                };

                _userRepository.Add(user);

                MessageBox.Show("User {0} has been created", user.FirstName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void LoadDropdownCountries()
        {
            var countries = _countryRepository.Get();
            cbCountries.DataSource = countries;
            
            cbCountries.DisplayMember = "CountryName";
            cbCountries.ValueMember = "CountryId";
            cbCountries.SelectedValue = 68;
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                e.Cancel = true;
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtPassword.Text) || txtPassword.TextLength < 4)
            {
                e.Cancel = true;
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
                e.Cancel = true;
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLastName.Text))
                e.Cancel = true;
        }

        private void txtIdentityNumber_Validating(object sender, CancelEventArgs e)
        {
            string identityLetter = "TRWAGMYFPDXBNJZSQVHLCKE";
            if (!string.IsNullOrEmpty(txtIdentityNumber.Text))
            {
                var firstCharacter = txtIdentityNumber.Text.Substring(0,1);
                string lastCharacter = string.Empty;
                int dniNumber = 0;

                int firstValueInt = 0;

                if(int.TryParse(firstCharacter, out firstValueInt))
                {
                    lastCharacter = txtIdentityNumber.Text.Substring(8);
                    dniNumber = Convert.ToInt32(txtIdentityNumber.Text.Substring(0, 7));
                    if(identityLetter.Substring(dniNumber % 23) != lastCharacter.ToUpper())
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    Regex regex;
                    if(firstCharacter == "X" || firstCharacter == "Y" || firstCharacter == "Z")
                    {
                        regex = new Regex(Regex.Escape(firstCharacter));
                        var textResult = regex.Replace(txtIdentityNumber.Text, firstCharacter == "X" ? "0" : firstCharacter == "Y" ? "1" : "2", 1);
                        lastCharacter = textResult.Substring(8);
                        dniNumber = Convert.ToInt32(textResult.Substring(0, 8));
                        if (identityLetter.Substring(dniNumber % 23, 1) != lastCharacter.ToUpper()) e.Cancel = true;
                        
                    }
                    else
                    {
                        
                        e.Cancel = true;
                    }
                }


            }
        }

    }
}
