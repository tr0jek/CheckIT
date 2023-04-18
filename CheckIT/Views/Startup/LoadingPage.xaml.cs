using CheckIT.ViewModels;

namespace CheckIT.Views.Startup;

public partial class LoadingPage : ContentPage
{
	public LoadingPage(LoadingPageModel vievModel)
	{
		InitializeComponent();
		this.BindingContext = vievModel;
	}
}