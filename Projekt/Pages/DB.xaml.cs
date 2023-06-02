using Microsoft.Maui.Controls.Shapes;

namespace Projekt.Pages;

public partial class DB : ContentPage
{
    TermRepository termRepository;

	string Name;
	string Surname;
	double BMI;
	string AllString;

	public DB(TermRepository termRepository)
	{
        InitializeComponent();
        this.termRepository = termRepository;
    }

    public async Task SaveState(string str)
    {

        string projectDirectory = AppContext.BaseDirectory;
        string relativePath = System.IO.Path.Combine(projectDirectory, "notesss.txt");

        string path = System.IO.Path.Combine(FileSystem.AppDataDirectory, "notesss.txt");

        // string path2 = @"C:\Users\20ib17_suchomel\source\repos\AdamSuchomel\BMIAPP\Projekt\Resources\Raw\notesss.txt";
        using (StreamWriter sw = new StreamWriter(relativePath, true))
        {
            await sw.WriteLineAsync(str);
            await sw.FlushAsync();
            sw.Close();

        }
    }

    private async void Save_Clicked(object sender, EventArgs e)
    {
        Term eTerm = new Term();

        Name = NAME.Text;
        Surname = SURNAME.Text;
        BMI = double.Parse(VALUE.Text);

        AllString = Name + " " + Surname + " " + "BMI " + BMI.ToString();

        await SaveState(AllString);

        eTerm.TheTerm = AllString;

        termRepository._list.Add(eTerm);

        await Navigation.PopAsync();
    }
}