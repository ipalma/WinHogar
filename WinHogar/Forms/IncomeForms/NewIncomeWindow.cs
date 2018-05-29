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
using WinHogar.Commons.Enums;
using WinHogar.ViewModels;

namespace WinHogar.Forms.IncomeForms
{
    public partial class NewIncomeWindow : Form
    {
        private readonly IRepository<Income, IncomeViewModel> _incomeRepository;
        private readonly IRepository<IncomeType, IncomeTypeViewModel> _incomeTypeRepo;
        private readonly IRepository<Models.EFModels.TotalAmount, TotalAmountViewModel> _totalAmountRepo;
        private readonly IRepository<User, UserViewModel> _userRepository;
        public NewIncomeWindow(IRepository<Income, IncomeViewModel> incomeRepository
            , IRepository<IncomeType, IncomeTypeViewModel> incomeTypeRepo
            , IRepository<Models.EFModels.TotalAmount, TotalAmountViewModel> totalAmountRepo
            , IRepository<User, UserViewModel> userRepository)
        {
            InitializeComponent();
            _incomeRepository = incomeRepository;
            _incomeTypeRepo = incomeTypeRepo;
            _totalAmountRepo = totalAmountRepo;
            _userRepository = userRepository;

            LoadIncomeWindowData();
        }

        private void LoadIncomeWindowData()
        {
            cbMonths.DataSource = Enum.GetValues(typeof(Months));
            cbIncomeType.DataSource = _incomeTypeRepo.Get();

            cbIncomeType.DisplayMember = "IncomeDescription";
            cbIncomeType.ValueMember = "IncomeTypeId";


            cbUsers.DataSource = _userRepository.Get();
            cbUsers.DisplayMember = "User1";
            cbUsers.ValueMember = "UserId";

        }

        private void txtIncomeAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIncomeAmount.Text))
            {
                e.Cancel = true;
            }
            else
            {
                decimal amount = 0;
                if(!decimal.TryParse(txtIncomeAmount.Text,out amount))
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnGuardarIncome_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new IncomeViewModel()
                {
                    Amount = Convert.ToDecimal(txtIncomeAmount.Text),
                    UserId = Convert.ToInt32(cbUsers.SelectedValue),
                    IncomeMonth = Enum.GetName(typeof(Months), Convert.ToInt32(cbMonths.SelectedValue)),
                    IncomeTypeId = Convert.ToInt32(cbIncomeType.SelectedValue),
                    IncomeDate = dateTimePicker1.Value,
                    rowguid = Guid.NewGuid()

                };

                var result = _incomeRepository.Add(data);

                if(result != null)
                {
                    var totalAmount = _totalAmountRepo.Get();

                    decimal lastAmount = 0;
                    TotalAmountViewModel lastTotalAmount = new TotalAmountViewModel();
                    if (totalAmount.Any())
                    {
                        lastTotalAmount = totalAmount.LastOrDefault();
                    }
                    else
                    {
                        lastTotalAmount.Amount = 0;
                    }

                    lastAmount = lastTotalAmount.Amount + data.Amount;

                    var dataTotalAmount = new TotalAmountViewModel()
                    {
                        Amount = lastAmount,
                        rowguid = Guid.NewGuid()
                    };
                    var resultTotal = _totalAmountRepo.Add(dataTotalAmount);
                }
                MessageBox.Show("Creado OK");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
