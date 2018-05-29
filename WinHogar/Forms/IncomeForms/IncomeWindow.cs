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
    public partial class IncomeWindow : Form
    {
        private readonly IRepository<Income, IncomeViewModel> _incomeRepository;
        public IncomeWindow(IRepository<Income, IncomeViewModel> incomeRepository)
        {
            InitializeComponent();
            _incomeRepository = incomeRepository;
            LoadIncomes();
        }

        private void LoadIncomes()
        {
            var incomeList = _incomeRepository.Get().OrderByDescending(x => x.IncomeId);

            dgvIncomes.DataSource = incomeList.ToList();
        }
    }
}
