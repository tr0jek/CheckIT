using CheckIT.Models;
using Java.Security;

namespace CheckIT;

public partial class App : Application
{
	public static UserBasicInfo UserDetails;
	public App()
	{
		
		InitializeComponent();

		MainPage = new AppShell();
	}
}
