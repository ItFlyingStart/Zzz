using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using Zzz.Core.Contracts.ViewModels;

namespace Zzz.Core.ViewModels
{
    public class MainViewModel : MvxViewModel, IMainViewModel
    {
        private readonly Lazy<SearchPasswordViewModel> _searchPasswordViewModel;

        public SearchPasswordViewModel SearchPasswordViewModel => _searchPasswordViewModel.Value;

        public MainViewModel()
        {
            _searchPasswordViewModel = new Lazy<SearchPasswordViewModel>(Mvx.IocConstruct<SearchPasswordViewModel>);
        }
    }
}
