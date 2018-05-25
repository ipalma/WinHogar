using Models.EFModels;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinHogar.ViewModels
{
    public class OutgoingsViewModel: IViewModel<Outgoings>
    {
        public int OutgoingId { get; set; }
        public string Description { get; set; }
        public Nullable<int> OutgoingType { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime OutgoingDate { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual OutgoingTypeViewModel OutgoingType1 { get; set; }

        public void FromDataBase(Outgoings model)
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

        public Outgoings ToDataBase()
        {
            throw new NotImplementedException();
        }

        public void UpdateDataBase(Outgoings model)
        {
            throw new NotImplementedException();
        }
    }
}
