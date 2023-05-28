namespace Projekt.Pages;

public partial class BMIPAGE : ContentPage
{
    double vyska;
    double hmotnost;
    public BMIPAGE()
    {
        InitializeComponent();
    }

    void Calculate(double weight, double height)
    {
        double result = weight / Math.Pow(height / 100, 2);
        Result.Text = result.ToString();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            vyska = double.Parse(Vyska.Text);
            hmotnost = Double.Parse(Hmotnost.Text);
            Calculate(hmotnost, vyska);
        }
        catch 
        {
            DisplayAlert("Chyba", "Špatný vstupní formát", "Potvrdit");
        }


    }

    private async void GRAPH_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GRAPH());
    }
}