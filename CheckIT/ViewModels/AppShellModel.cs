using CheckIT.Views.Startup;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIT.ViewModels
{
    public partial class AppShellModel : MainViewModel
    {
        [RelayCommand]

        async void SingOut()
        {

            if (Preferences.ContainsKey(nameof(App.UserDetails)))
            {
                Preferences.Remove(nameof(App.UserDetails));
            }

            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
