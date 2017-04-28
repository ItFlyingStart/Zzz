using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using Zzz.Core.Contracts.ViewModels;

namespace Zzz.Core.ViewModels
{
    public class MainViewModel : MvxViewModel, IMainViewModel
    {
        private readonly Lazy<PasswordOverviewViewModel> _passwordOverviewViewModel;

        public PasswordOverviewViewModel PasswordOverviewViewModel => _passwordOverviewViewModel.Value;

        //private readonly Lazy<TestViewModel> _testViewModel;

        //public TestViewModel TestViewModel => _testViewModel.Value;

        public MainViewModel()
        {
            _passwordOverviewViewModel = new Lazy<PasswordOverviewViewModel>(Mvx.IocConstruct<PasswordOverviewViewModel>);
            //_testViewModel = new Lazy<TestViewModel>(Mvx.IocConstruct<TestViewModel>);
        }

        public void ShowPasswordOverview()
        {
            ShowViewModel<PasswordOverviewViewModel>();
            //ShowViewModel<TestViewModel>();
        }
    }
}
