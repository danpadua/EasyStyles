using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EasyStylesApp.ViewModels
{
    public class InicialPageViewModel : BindableBase
    {
        public DelegateCommand NavigateCommand { get; set; }
        private readonly INavigationService _navigationService;

        public InicialPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new DelegateCommand(InicialCommand);
        }

        public void InicialCommand()
        {
            _navigationService.NavigateAsync("NavegacaoPage/MainPage");
        }
    }
}
