using Models.EFModels;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinHogar.ViewModels
{
    public class UserAddressViewModel:IViewModel<UserAddress>
    {
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual AddressViewModel Address { get; set; }
        public virtual UserViewModel User { get; set; }

        public void FromDataBase(UserAddress model)
        {
            throw new NotImplementedException();
        }

        public Guid[] GetGuids()
        {
            throw new NotImplementedException();
        }

        public int[] GetKeys()
        {
            throw new NotImplementedException();
        }

        public UserAddress ToDataBase()
        {
            throw new NotImplementedException();
        }

        public void UpdateDataBase(UserAddress model)
        {
            throw new NotImplementedException();
        }
    }
}
