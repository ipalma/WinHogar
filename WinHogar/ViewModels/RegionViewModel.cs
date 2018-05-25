using Models.EFModels;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinHogar.ViewModels
{
    public class RegionViewModel:IViewModel<Region>
    {
        public RegionViewModel()
        {
            this.Province = new HashSet<ProvinceViewModel>();
        }

        public int RegionId { get; set; }
        public string RegionName { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<ProvinceViewModel> Province { get; set; }

        public void FromDataBase(Region model)
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

        public Region ToDataBase()
        {
            throw new NotImplementedException();
        }

        public void UpdateDataBase(Region model)
        {
            throw new NotImplementedException();
        }
    }
}
