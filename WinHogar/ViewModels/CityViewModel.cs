using Models.EFModels;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinHogar.ViewModels
{
    public class CityViewModel:IViewModel<City>
    {
        public CityViewModel()
        {
            this.Address = new HashSet<AddressViewModel>();
        }

        public int CityId { get; set; }
        public int ProvinceId { get; set; }
        public string CityName { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<int> DC { get; set; }
        public Nullable<int> city_code { get; set; }

       
        public virtual ICollection<AddressViewModel> Address { get; set; }
        public virtual ProvinceViewModel Province { get; set; }

        public void FromDataBase(City model)
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

        public City ToDataBase()
        {
            throw new NotImplementedException();
        }

        public void UpdateDataBase(City model)
        {
            throw new NotImplementedException();
        }
    }
}
