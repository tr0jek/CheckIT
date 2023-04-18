using CheckIT.Models;
using CheckIT.Views.Dashboard;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CheckIT.ViewModels
{
    public partial class LoginPageModel : MainViewModel
    {
        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _password;

        #region Commands
        [RelayCommand]

        async void Login()
        {
            if(string.IsNullOrWhiteSpace(Email)&& string.IsNullOrWhiteSpace(Password))
            {
                //calling api
                var userDetails = new UserBasicInfo()
                {
                    Email = Email,
                    FullName = "Test User Name"
                };

                if (Preferences.ContainsKey(nameof(App.UserDetails)))
                {
                    Preferences.Remove(nameof(App.UserDetails));
                }
                string userDetailStr=JsonConvert.SerializeObject(userDetails);
                Preferences.Set(nameof(App.UserDetails),userDetailStr);
                App.UserDetails = userDetails;

                await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");
            }

           
        }
        #endregion
    }
}
