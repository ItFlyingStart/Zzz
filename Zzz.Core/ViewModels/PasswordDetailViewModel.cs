using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Plugins.Messenger;
using Zzz.Core.Contracts.Services;
using Zzz.Core.Contracts.ViewModels;
using Zzz.Core.Models;
using Zzz.Core.Services.Data;
using Zzz.Core.Repositories;
using System.Collections.ObjectModel;

namespace Zzz.Core.ViewModels
{
    public class PasswordDetailViewModel : BaseViewModel, IPasswordDetailViewModel
    {
        private readonly IPasswordDataService _passwordDataService;
        private Password _selectedPassword;
        private Group _selectedGroup;
        private Collection<Group> _allGroups;
        private string _passwordId;

        public Password SelectedPassword
        {
            get { return _selectedPassword; }
            set
            {
                _selectedPassword = value;
                RaisePropertyChanged(() => SelectedPassword);
            }
        }

        public Group SelectedGroup
        {
            get { return _selectedGroup; }
            set
            {
                _selectedGroup = value;
                RaisePropertyChanged(() => SelectedGroup);
            }
        }

        public Collection<Group> AllGroups
        {
            get { return _allGroups; }
        }

        public PasswordDetailViewModel(IMvxMessenger messenger) : base(messenger)
        {
            _passwordDataService = new PasswordDataService(new PasswordRepository());
        }

        public void Init(string passwordId)
        {
            _passwordId = passwordId;

            if (_passwordId == string.Empty)
            {
                SelectedPassword = new Password();
                SelectedGroup = new Group();
            }
        }

        public override async void Start()
        {
            base.Start();
            await ReloadDataAsync();
        }

        protected override async Task InitializeAsync()
        {
            SelectedPassword = await _passwordDataService.GetPasswordById(_passwordId);
            if (SelectedPassword != null)
            {
                SelectedGroup = await _passwordDataService.GetGroupById(SelectedPassword.PasswordGroup.Id);
            }
        }
    }
}
