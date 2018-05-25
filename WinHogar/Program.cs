using Models.EFModels;
using Repository.Interfaces;
using Repository.Implements;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinHogar.ViewModels;
using System.Data.Entity;

namespace WinHogar
{
    static class Program
    {
        private static Container container;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(container.GetInstance<LoginWindow>());
        }

        private static void Bootstrap()
        {
            container = new Container();

            container.Register<IRepository<Address,AddressViewModel>,Repository<Address,AddressViewModel>>();
            container.Register<IRepository<City, CityViewModel>, Repository<City, CityViewModel>>();
            container.Register<IRepository<Country, CountryViewModel>, Repository<Country,CountryViewModel>>();
            container.Register<IRepository<Income, IncomeViewModel>, Repository<Income, IncomeViewModel>>();
            container.Register<IRepository<IncomeType, IncomeTypeViewModel>, Repository<IncomeType, IncomeTypeViewModel>>();
            container.Register<IRepository<Outgoings, OutgoingsViewModel>, Repository<Outgoings,OutgoingsViewModel>>();
            container.Register<IRepository<OutgoingType, OutgoingTypeViewModel>, Repository<OutgoingType, OutgoingTypeViewModel>>();
            container.Register<IRepository<PredefinedOutgoins,PredefinedOutgoingsViewModel>, Repository<PredefinedOutgoins,PredefinedOutgoingsViewModel>>();
            container.Register<IRepository<Province,ProvinceViewModel>, Repository<Province,ProvinceViewModel>>();
            container.Register<IRepository<Region, RegionViewModel>, Repository<Region,RegionViewModel>>();
            container.Register<IRepository<TotalAmount,TotalAmountViewModel>, Repository<TotalAmount,TotalAmountViewModel>>();
            container.Register<IRepository<User, UserViewModel>, Repository<User, UserViewModel>>();
            container.Register<IRepository<UserAddress,UserAddressViewModel>, Repository<UserAddress,UserAddressViewModel>>();

            container.Register<DbContext, HogarEntities>();

            container.Register<LoginWindow>();
        }
    }
}
