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
            TotalAmountId = model.TotalAmountId;
            Amount = model.Amount;
            rowguid = model.rowguid;
        }

        public Guid[] GetGuids()
        {
            return new Guid[] { rowguid };
        }

        public int[] GetKeys()
        {
            return new int[] { TotalAmountId };
        }

        public TotalAmount ToDataBase()
        {
            var data = new TotalAmount()
            {
                TotalAmountId = TotalAmountId,
                Amount = Amount,
                rowguid = rowguid
            };
            return data;
        }

        public void UpdateDataBase(TotalAmount model)
        {
            model.TotalAmountId = TotalAmountId;
            model.Amount = Amount;
            model.rowguid = rowguid;
        }
    }
}
