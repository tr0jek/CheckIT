using CheckIT.Views.Dashboard;
using CheckIT.ViewModels;
namespace CheckIT;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		this.BindingContext = new AppShellModel();
		Routing.RegisterRoute(nameof(DashboardPage), typeof(DashboardPage));
	}
}
