using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GoninDigital.Models;
using GoninDigital.Utils;
using GoninDigital.Views;
using GoninDigital.Properties;
using System.Windows;

namespace GoninDigital.ViewModels
{
    internal class SettingPageViewModel : BaseViewModel
    {
        public ICommand LogoutCommand { get; set; }
        public SettingPageViewModel(Views.DashBoardPages.SettingPage settingPage)
        {
            LogoutCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                Settings.Default.Username = "";
                Settings.Default.Password = "";
                Settings.Default.isAdmin = false;

                var loginWindow = new LoginViewModel(Application.Current.MainWindow);
                WindowManager.ChangeWindowContent(Application.Current.MainWindow, loginWindow, "", Resources.LoginControlPath);
            });
        }
    }
}
