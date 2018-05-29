using Models.EFModels;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinHogar.ViewModels;

namespace WinHogar.Forms.IncomeForms
{
    public partial class NewIncomeTypeWindow : Form
    {
        private readonly IRepository<IncomeType, IncomeTypeViewModel> _incomeTypeRepo;
        public NewIncomeTypeWindow(IRepository<IncomeType, IncomeTypeViewModel> incomeTypeRepo)
        {
            InitializeComponent();
            _incomeTypeRepo = incomeTypeRepo;
        }

        private void btnRegisterIncomeType_Click(object sender, EventArgs e)
        {
            var incomeType = new IncomeTypeViewModel()
            {
                IncomeDescription = txtIncomeTypeDescription.Text,
                ModifiedDate = DateTime.Now,
                rowguid = Guid.NewGuid()
            };
            try
            {
                var data = _incomeTypeRepo.Add(incomeType);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }
    }
}
