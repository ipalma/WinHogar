using Models.EFModels;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinHogar.ViewModels
{
    public class PredefinedOutgoingsViewModel:IViewModel<PredefinedOutgoins>
    {
        public int PredefinedOutgoingId { get; set; }
        public string Description { get; set; }
        public decimal OutgoingAmount { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public void FromDataBase(PredefinedOutgoins model)
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

        public PredefinedOutgoins ToDataBase()
        {
            throw new NotImplementedException();
        }

        public void UpdateDataBase(PredefinedOutgoins model)
        {
            throw new NotImplementedException();
        }
    }
}
