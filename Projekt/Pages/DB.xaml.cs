using Microsoft.Maui.Controls.Shapes;

namespace Projekt.Pages;

public partial class DB : ContentPage
{
    TermRepository termRepository;
    Term term;

	string Name;
	string Surname;
	double BMI;
	string AllString;

	public DB()
	{
        InitializeComponent();

    }

    public async Task SaveState(string str)
    {
        string path2 = @"C:\Users\wpj\Downloads\Projekt\Projekt\Projekt\Resources\Raw\notesss.txt";
        string path = System.IO.Path.Combine(FileSystem.Current.AppDataDirectory, "notesss.txt");
        using (StreamWriter sw = new StreamWriter(path2, true))
        {
            await sw.WriteLineAsync(str);
            await sw.FlushAsync();
            sw.Close();

        }
    }

    private async void Save_Clicked(object sender, EventArgs e)
    { 
        Name = NAME.Text;
        Surname = SURNAME.Text;
        BMI = double.Parse(VALUE.Text);

        AllString = Name + ", " + Surname + " " + "BMI " + BMI.ToString();

        await SaveState(AllString);

        await Navigation.PopAsync();
    }
}