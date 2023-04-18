using CheckIT.ViewModels;

namespace CheckIT.Views.Startup;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginPageModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}