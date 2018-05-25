using Models.EFModels;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinHogar.ViewModels
{
    public class CountryViewModel:IViewModel<Country>
    {
        public CountryViewModel()
        {
            this.User = new HashSet<UserViewModel>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
       
        public virtual ICollection<UserViewModel> User { get; set; }

        public void FromDataBase(Country model)
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

        public Country ToDataBase()
        {
            throw new NotImplementedException();
        }

        public void UpdateDataBase(Country model)
        {
            throw new NotImplementedException();
        }
    }
}
