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
            IncomeTypeId = model.IncomeTypeId;
            IncomeDescription = model.IncomeDescription;
            rowguid = model.rowguid;
            ModifiedDate = model.ModifiedDate;
            try
            {
                Income = model.Income.Select(x => new IncomeViewModel()
                {
                    IncomeId = x.IncomeId,
                    IncomeTypeId = x.IncomeTypeId,
                    Amount = x.Amount,
                    IncomeDate = x.IncomeDate,
                    IncomeMonth = x.IncomeMonth,
                    rowguid = x.rowguid
                }).ToList();
            }
            catch(Exception ex)
            {

            }
        }

        public Guid[] GetGuids()
        {
            return new Guid[] { rowguid };
        }

        public int[] GetKeys()
        {
            return new int[] { IncomeTypeId };
        }

        public IncomeType ToDataBase()
        {
            var data = new IncomeType()
            {
                IncomeTypeId = IncomeTypeId,
                IncomeDescription = IncomeDescription,
                rowguid = rowguid,
                ModifiedDate = ModifiedDate
            };
            return data;
        }

        public void UpdateDataBase(IncomeType model)
        {
            model.IncomeTypeId = IncomeTypeId;
            model.IncomeDescription = IncomeDescription;
            model.rowguid = rowguid;
            model.ModifiedDate = ModifiedDate;
        }
    }
}
