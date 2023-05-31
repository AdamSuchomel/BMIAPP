using Projekt.Pages;
using Syncfusion.Maui.Charts;
using System.Collections.ObjectModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Windows.Input;
using System.Xml.Linq;

namespace Projekt;

public partial class MainPage : ContentPage
{
    TermRepository termRepository;
    SfCartesianChart chart;
    public MainPage()
	{
        termRepository = new TermRepository();
        BindingContext = termRepository;
        InitializeComponent();

        
    }

    public async Task DeleteAllFromFile(string str)
    {
        string path2 = @"C:\Users\20ib17_suchomel\source\repos\AdamSuchomel\BMIAPP\Projekt\Resources\Raw\notesss.txt";
        string path = System.IO.Path.Combine(FileSystem.Current.AppDataDirectory, "notesss.txt");
        using (StreamWriter sw = new StreamWriter(path2, false))
        {
            await sw.WriteLineAsync(str);
            await sw.FlushAsync();
            sw.Close();

        }
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

    private async void Refresh_Clicked(object sender, EventArgs e)
    {
        //lbl.Text = termRepository._list.Count.ToString();
        string AllString = "";

        await DeleteAllFromFile(AllString);
        termRepository._list.Clear();
    }

    private async void BMI_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new aboutbmi());
    }
}

