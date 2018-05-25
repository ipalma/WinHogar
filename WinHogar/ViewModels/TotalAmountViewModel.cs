using Models.EFModels;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinHogar.ViewModels
{
    public class TotalAmountViewModel:IViewModel<TotalAmount>
    {
        public int TotalAmountId { get; set; }
        public decimal Amount { get; set; }
        public System.Guid rowguid { get; set; }

        public void FromDataBase(TotalAmount model)
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

        public TotalAmount ToDataBase()
        {
            throw new NotImplementedException();
        }

        public void UpdateDataBase(TotalAmount model)
        {
            throw new NotImplementedException();
        }
    }
}
