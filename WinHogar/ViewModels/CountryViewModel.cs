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
            CountryId = model.CountryId;
            CountryCode = model.CountryCode;
            CountryName = model.CountryName;
            rowguid = model.rowguid;
            ModifiedDate = model.ModifiedDate;
        }

        public Guid[] GetGuids()
        {
            return new Guid[] { rowguid };
        }

        public int[] GetKeys()
        {
            return new int[] { CountryId };
        }

        public Country ToDataBase()
        {
            var data = new Country()
            {
                CountryId = CountryId,
                CountryCode = CountryCode,
                CountryName = CountryName,
                rowguid = rowguid,
                ModifiedDate = ModifiedDate
            };
            return data;
        }

        public void UpdateDataBase(Country model)
        {
            model.CountryId = CountryId;
            model.CountryCode = CountryCode;
            model.CountryName = CountryName;
            model.rowguid = rowguid;
            model.ModifiedDate = ModifiedDate;
        }
    }
}
