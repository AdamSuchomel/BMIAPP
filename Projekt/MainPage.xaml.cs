using Projekt.Pages;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

namespace Projekt;

public partial class MainPage : ContentPage
{ 
    TermRepository termRepository;
	public MainPage()
	{
        termRepository = new TermRepository();
        BindingContext = termRepository;
        InitializeComponent();

        
    }


   
    private async void CALCULATE_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BMIPAGE());
    }

    private async void CHECKBMI_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CHECKBMI());
    }
    private async void ADD_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DB(termRepository));
    }

    private void Refresh_Clicked(object sender, EventArgs e)
    {
        lbl.Text = termRepository._list.Count.ToString();
    }

    private async void BMI_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new aboutbmi());
    }
}

