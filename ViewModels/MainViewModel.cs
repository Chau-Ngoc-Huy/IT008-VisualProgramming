using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows;
using GoninDigital.Models;
using GoninDigital.Views;
using System.Windows.Input;
using GoninDigital.Utils;
using GoninDigital.Properties;
using System.Reflection;

namespace GoninDigital.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand LoadedWidnowCommand { get; set; }

        public MainViewModel()
        {
            LoadedWidnowCommand = new RelayCommand<Window>((p) => { return true; }, (p) => {
                if (Settings.Default.Username.ToString() != "")
                {
                    var dashboardWindow = new DashBoard();
                    if (Settings.Default.isAdmin) //admin
                    {
                        Settings.Default.isAdmin = false;
                        _ = WindowManager.ChangeWindowContent(p, dashboardWindow, "", Resources.AdminControlPath);
                    }
                    else //user
                    {
                        _ = WindowManager.ChangeWindowContent(p, dashboardWindow, "", Resources.UserControlPath);
                    }
                }
                else //login
                {
                    var loginWindow = new LoginViewModel(p);
                    _ = WindowManager.ChangeWindowContent(p, loginWindow, "", Resources.LoginControlPath);
                }

            }); 
        }
    }
}
