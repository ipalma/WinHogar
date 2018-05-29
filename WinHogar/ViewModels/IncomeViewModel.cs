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
        public int? UserId { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime IncomeDate { get; set; }
        public string IncomeMonth { get; set; }
        public Guid rowguid { get; set; }

        public virtual IncomeTypeViewModel IncomeType { get; set; }

        public void FromDataBase(Income model)
        {
            IncomeId = model.IncomeId;
            IncomeTypeId = model.IncomeTypeId;
            UserId = model.UserId;
            Amount = model.Amount;
            IncomeDate = model.IncomeDate;
            IncomeMonth = model.IncomeMonth;
            rowguid = model.rowguid;

            if(model.IncomeType != null)
            {
                IncomeType = new IncomeTypeViewModel()
                {
                    IncomeTypeId = model.IncomeType.IncomeTypeId,
                    IncomeDescription = model.IncomeType.IncomeDescription,
                    rowguid = model.IncomeType.rowguid,
                    ModifiedDate = model.IncomeType.ModifiedDate
                };
            }
            else
            {
                IncomeType = new IncomeTypeViewModel();
            }
            
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
            var data = new Income()
            {
                IncomeId = IncomeId,
                IncomeTypeId = IncomeTypeId,
                UserId = UserId,
                Amount = Amount,
                IncomeDate = IncomeDate,
                IncomeMonth = IncomeMonth,
                rowguid = rowguid
            };
            return data;

        }

        public void UpdateDataBase(Income model)
        {
            model.IncomeId = IncomeId;
            model.IncomeTypeId = IncomeTypeId;
            model.UserId = UserId;
            model.Amount = Amount;
            model.IncomeDate = IncomeDate;
            model.IncomeMonth = IncomeMonth;
            model.rowguid =rowguid;
        }
    }
}
