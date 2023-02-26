namespace FoodHealty;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void vaiProLogin(object sender, EventArgs e)
	{
        Shell.Current.Navigation.PushAsync(new NovaPasta1.Login());

    }
}

