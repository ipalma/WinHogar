using Models.EFModels;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinHogar.ViewModels
{
    public class OutgoingTypeViewModel:IViewModel<OutgoingType>
    {
        public OutgoingTypeViewModel()
        {
            this.Outgoings = new HashSet<OutgoingsViewModel>();
        }

        public int OutgoingTypeId { get; set; }
        public string Description { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<OutgoingsViewModel> Outgoings { get; set; }

        public void FromDataBase(OutgoingType model)
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

        public OutgoingType ToDataBase()
        {
            throw new NotImplementedException();
        }

        public void UpdateDataBase(OutgoingType model)
        {
            throw new NotImplementedException();
        }
    }
}
