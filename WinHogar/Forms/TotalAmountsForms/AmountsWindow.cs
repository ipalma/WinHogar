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
using Models.EFModels;

namespace WinHogar.Forms.TotalAmountsForms
{
    public partial class AmountsWindow : Form
    {
        private readonly IRepository<Models.EFModels.TotalAmount, TotalAmountViewModel> _totalAmountRepo;
        public AmountsWindow(IRepository<Models.EFModels.TotalAmount, TotalAmountViewModel> totalAmountRepo)
        {
            InitializeComponent();
            _totalAmountRepo = totalAmountRepo;
            LoadTotalAmountData();
        }

        private void LoadTotalAmountData()
        {
            var data = _totalAmountRepo.Get().OrderByDescending(x => x.TotalAmountId);
            dgvAmounts.DataSource = data.ToList();
        }
    }
}
