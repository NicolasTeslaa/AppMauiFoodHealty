namespace FoodHealty.NovaPasta1;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}
	private void dadosCliente(object sender, EventArgs e)
	{
		Shell.Current.Navigation.PushModalAsync(new NovaPasta1.dadosCliente());
	}
}