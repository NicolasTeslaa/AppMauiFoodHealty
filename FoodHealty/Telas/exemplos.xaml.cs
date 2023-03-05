namespace FoodHealty.Telas;

public partial class exemplos : ContentPage
{
	public exemplos()
	{
		InitializeComponent();
	}

    private void verHorizontalStackLayout(object sender, EventArgs e)
	{
		Shell.Current.Navigation.PushAsync(new exemploHorizontalStackLayout());
	}
}