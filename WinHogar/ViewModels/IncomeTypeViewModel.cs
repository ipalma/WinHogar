using Models.EFModels;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinHogar.ViewModels
{
    public class IncomeTypeViewModel: IViewModel<IncomeType>
    {
        public IncomeTypeViewModel()
        {
            this.Income = new HashSet<IncomeViewModel>();
        }

        public int IncomeTypeId { get; set; }
        public string IncomeDescription { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

       
        public virtual ICollection<IncomeViewModel> Income { get; set; }

        public void FromDataBase(IncomeType model)
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

        public IncomeType ToDataBase()
        {
            throw new NotImplementedException();
        }

        public void UpdateDataBase(IncomeType model)
        {
            throw new NotImplementedException();
        }
    }
}
