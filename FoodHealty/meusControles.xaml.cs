namespace FoodHealty;

public partial class meusControles : ContentView
{
	public static readonly BindableProperty TitleTextProperty = BindableProperty.Create(nameof(TitleText),
		typeof(string), typeof(meusControles));

	public string TitleText { get; set; }


	public meusControles()
	{
		InitializeComponent();
	}

}