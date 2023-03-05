namespace FoodHealty.Telas;

public partial class exemploHorizontalStackLayout : ContentPage
{
	public exemploHorizontalStackLayout()
	{
		InitializeComponent();
	}

	private void verBordas(object sender, EventArgs e)
	{
		Shell.Current.Navigation.PushAsync(new exemplosBordas());
	}
}