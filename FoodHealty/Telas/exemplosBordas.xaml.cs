namespace FoodHealty.Telas;

public partial class exemplosBordas : ContentPage
{
	public exemplosBordas()
	{
		InitializeComponent();
	}
	private void irShadows(object sender, EventArgs e)
	{
		Shell.Current.Navigation.PushAsync(new shadows());
	}
}