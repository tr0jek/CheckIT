using CheckIT.Views.Dashboard;
using CheckIT.Views.Startup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIT.ViewModels
{
    public class LoadingPageModel 
    {
        public LoadingPageModel()
        {
            CheckUserLoginDetails();
        }
        private async void CheckUserLoginDetails()
        {
            string userDetailsStr = Preferences.Get(nameof(App.UserDetails), "");

            if(string.IsNullOrEmpty(userDetailsStr))
            {
                await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
                // navigate to login lage
            }
            else
            {
                await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");
                //dashboard
            }
        }
    }
}
