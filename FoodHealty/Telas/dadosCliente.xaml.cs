using System.Globalization;
namespace FoodHealty.NovaPasta1;
public partial class dadosCliente : ContentPage
{

    public dadosCliente()
	{
		InitializeComponent();
    }
    void OnDateSelected(object sender, DateChangedEventArgs args)
    {
        Console.WriteLine(((DatePicker)sender).Date);
        Console.WriteLine(((DatePicker)sender).Date.ToString("d"));
        Console.WriteLine(((DatePicker)sender).Date.ToString("D"));
        Console.WriteLine(((DatePicker)sender).Date.ToString("f"));
        Console.WriteLine(((DatePicker)sender).Date.ToString("F"));

        CultureInfo culture = new CultureInfo("pt-BR");
        Console.WriteLine(((DatePicker)sender).Date.ToString("d", culture));
        culture = CultureInfo.InvariantCulture;
        Console.WriteLine(((DatePicker)sender).Date.ToString("d", culture));
    }

}