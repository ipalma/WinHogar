using Models.EFModels;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinHogar.ViewModels
{
    public class IncomeViewModel: IViewModel<Income>
    {
        public int IncomeId { get; set; }
        public int IncomeTypeId { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime IncomeDate { get; set; }
        public string IncomeMonth { get; set; }
        public string rowguid { get; set; }

        public virtual IncomeTypeViewModel IncomeType { get; set; }

        public void FromDataBase(Income model)
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

        public Income ToDataBase()
        {
            throw new NotImplementedException();
        }

        public void UpdateDataBase(Income model)
        {
            throw new NotImplementedException();
        }
    }
}
