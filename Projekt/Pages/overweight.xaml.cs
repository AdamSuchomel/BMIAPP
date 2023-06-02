namespace Projekt.Pages;

public partial class overweight : ContentPage
{
	public overweight()
	{
		InitializeComponent();
	}

    private async void Back_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}