using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using EasyStylesApp.Models;
using EasyStylesApp.Utils;

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
