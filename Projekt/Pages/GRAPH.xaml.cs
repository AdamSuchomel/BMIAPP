namespace Projekt.Pages;

public partial class GRAPH : ContentPage
{
	public GRAPH()
	{
		InitializeComponent();
	}

    private async void underweight_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new underweight());
    }

    private async void overweight_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new overweight());
    }

    private async void Back_Clicked(object sender, EventArgs e)
    {
       await Navigation.PopAsync();
    }
}