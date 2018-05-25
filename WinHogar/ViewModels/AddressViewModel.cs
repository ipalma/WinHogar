using Models.EFModels;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinHogar.ViewModels
{
    public class AddressViewModel: IViewModel<Address>
    {
        public AddressViewModel()
        {
            this.UserAddress = new HashSet<UserAddressViewModel>();
        }

        public int AddressId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int City { get; set; }
        public string PostalCode { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string NumberLine1 { get; set; }
        public string FloorLine1 { get; set; }
        public string DoorLine1 { get; set; }
        public string StairLine { get; set; }

        public virtual CityViewModel City1 { get; set; }
        public virtual ICollection<UserAddressViewModel> UserAddress { get; set; }

        public void FromDataBase(Address model)
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

        public Address ToDataBase()
        {
            throw new NotImplementedException();
        }

        public void UpdateDataBase(Address model)
        {
            throw new NotImplementedException();
        }
    }
}
