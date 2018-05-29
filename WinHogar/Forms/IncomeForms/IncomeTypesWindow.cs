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
    public partial class IncomeTypesWindow : Form
    {
        private readonly IRepository<IncomeType, IncomeTypeViewModel> _incomeTypeRepo;
        public IncomeTypesWindow(IRepository<IncomeType, IncomeTypeViewModel> incomeTypeRepo)
        {
            InitializeComponent();
            _incomeTypeRepo = incomeTypeRepo;
            LoadIncomeTypesWindowData();
        }
        private void LoadIncomeTypesWindowData()
        {
            var data = _incomeTypeRepo.Get();
            dgvIncomeTypes.DataSource = data;

        }
    }
}
