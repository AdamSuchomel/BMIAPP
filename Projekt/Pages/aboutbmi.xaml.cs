namespace Projekt.Pages;

public partial class aboutbmi : ContentPage
{
	public aboutbmi()
	{
		InitializeComponent();
	}

    private async void Back_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}