using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCross.Plugins.Messenger;
using Zzz.Core.Contracts.Services;
using Zzz.Core.Contracts.ViewModels;

namespace Zzz.Core.ViewModels
{
    public class SearchPasswordViewModel : BaseViewModel, ISearchPasswordViewModel
    {
        public SearchPasswordViewModel(IMvxMessenger messenger) : base(messenger)
        {
        }
    }
}
