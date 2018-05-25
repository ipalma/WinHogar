using Models.EFModels;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinHogar.ViewModels
{
    public class ProvinceViewModel: IViewModel<Province>
    {
        public ProvinceViewModel()
        {
            this.City = new HashSet<CityViewModel>();
        }

        public int ProvinceId { get; set; }
        public int RegionId { get; set; }
        public string ProvinceName { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<CityViewModel> City { get; set; }
        public virtual RegionViewModel Region { get; set; }

        public void FromDataBase(Province model)
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

        public Province ToDataBase()
        {
            throw new NotImplementedException();
        }

        public void UpdateDataBase(Province model)
        {
            throw new NotImplementedException();
        }
    }
}
