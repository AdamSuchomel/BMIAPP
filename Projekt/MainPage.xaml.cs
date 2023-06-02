using Projekt.Pages;
using Syncfusion.Maui.Charts;
using System.Collections.ObjectModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Windows.Input;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

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
        string projectDirectory = AppContext.BaseDirectory;
        string relativePath = System.IO.Path.Combine(projectDirectory, "notesss.txt");

 
       
        using (StreamWriter sw = new StreamWriter(relativePath, false))
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

