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
using WinHogar.Forms.IncomeForms;
using WinHogar.Forms.TotalAmountsForms;
using WinHogar.ViewModels;

namespace WinHogar.Forms
{
    public partial class MenuWindow : Form
    {
        private readonly IRepository<User, UserViewModel> _userRepository;
        private readonly IRepository<Income, IncomeViewModel> _incomeRepository;
        private readonly IRepository<IncomeType, IncomeTypeViewModel> _incomeTypeRepo;
        private readonly IRepository<Models.EFModels.TotalAmount, TotalAmountViewModel> _totalAmountRepository;
        public MenuWindow(IRepository<User, UserViewModel> userRepository
            , IRepository<Income, IncomeViewModel> incomeRepository
            , IRepository<IncomeType, IncomeTypeViewModel> incomeTypeRepo
            , IRepository<Models.EFModels.TotalAmount, TotalAmountViewModel> totalAmountRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _incomeRepository = incomeRepository;
            _incomeTypeRepo = incomeTypeRepo;
            _totalAmountRepository = totalAmountRepository;
        }

        private void mainIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncomeWindow incomes = new IncomeWindow(_incomeRepository);
            incomes.MdiParent = this;
            incomes.Show();
        }

        private void newIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewIncomeWindow newIncome = new NewIncomeWindow(_incomeRepository, _incomeTypeRepo, _totalAmountRepository, _userRepository);
            newIncome.MdiParent = this;
            newIncome.Show();

        }

        private void newIncomeTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewIncomeTypeWindow incomeTypeWindow = new NewIncomeTypeWindow(_incomeTypeRepo);
            incomeTypeWindow.MdiParent = this;
            incomeTypeWindow.Show();
        }

        private void incomeTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncomeTypesWindow incomeTypesWindow = new IncomeTypesWindow(_incomeTypeRepo);
            incomeTypesWindow.MdiParent = this;
            incomeTypesWindow.Show();
        }

        private void amountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AmountsWindow amountsWindow = new AmountsWindow(_totalAmountRepository);
            amountsWindow.MdiParent = this;
            amountsWindow.Show();
        }
    }
}
