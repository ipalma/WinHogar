using Models.EFModels;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinHogar.ViewModels
{
    public class UserViewModel:IViewModel<User>
    {
        public UserViewModel()
        {
            this.UserAddress = new HashSet<UserAddressViewModel>();
        }

        public int UserId { get; set; }
        public string User1 { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public string IdentityNumber { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public System.Guid rowguid { get; set; }
        public int Nationality { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual CountryViewModel Country { get; set; }
        
        public virtual ICollection<UserAddressViewModel> UserAddress { get; set; }

        public void FromDataBase(User model)
        {
            UserId = model.UserId;
            User1 = model.User1;
            Password = model.Password;
            FirstName = model.FirstName;
            MiddleName = model.MiddleName;
            LastName = model.LastName;
            SecondLastName = model.SecondLastName;
            IdentityNumber = model.IdentityNumber;
            BirthDate = model.BirthDate;
            Email = model.Email;
            rowguid = model.rowguid;
            Nationality = model.Nationality;
            CreateDate = model.CreateDate;
            ModifiedDate = model.ModifiedDate;
        }

        public Guid[] GetGuids()
        {
            return new Guid[] { rowguid };
        }

        public int[] GetKeys()
        {
            return new int[] { UserId };
        }

        public User ToDataBase()
        {
            User data = new User()
            {
                UserId = UserId,
                User1 = User1,
                Password = Password,
                FirstName = FirstName,
                MiddleName = MiddleName,
                LastName = LastName,
                SecondLastName = SecondLastName,
                IdentityNumber = IdentityNumber,
                BirthDate = BirthDate,
                Email = Email,
                rowguid = rowguid,
                Nationality = Nationality,
                CreateDate = CreateDate,
                ModifiedDate = ModifiedDate,
            };

            return data;
        }

        public void UpdateDataBase(User model)
        {
            model.UserId = UserId;
            model.User1 = User1;
            model.Password = Password;
            model.FirstName = FirstName;
            model.MiddleName = MiddleName;
            model.LastName = LastName;
            model.SecondLastName = SecondLastName;
            model.IdentityNumber = IdentityNumber;
            model.BirthDate = BirthDate;
            model.Email = Email;
            model.rowguid = rowguid;
            model.Nationality = Nationality;
            model.CreateDate = CreateDate;
            model.ModifiedDate = ModifiedDate;
        }
    }
}
