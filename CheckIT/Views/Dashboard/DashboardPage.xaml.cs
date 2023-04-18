using CheckIT.ViewModels.Dashboard;

namespace CheckIT.Views.Dashboard;

public partial class DashboardPage : ContentPage
{
	public DashboardPage(DashboardPageModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}