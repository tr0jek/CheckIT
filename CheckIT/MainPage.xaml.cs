using CheckIT.ViewModels;

namespace CheckIT;

public partial class MainPage : ContentPage
{
	

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

	private void AddCheck(object sender, EventArgs e)
	{
		Console.WriteLine("lol");
    }
}

