namespace Projekt.Pages;

public partial class underweight : ContentPage
{
	public underweight()
	{
		InitializeComponent();
	}

    private async void Back_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}