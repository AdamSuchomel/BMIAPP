using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Charts
{
    public class ViewModel
    {

        public List<Models> Data { get; set; }

        public ViewModel()
        {
            Data = new List<Models>()
        {
            new Models { Time = "1990 ", BMI = 21.9 },
            new Models { Time = "2000", BMI = 23.3 },
            new Models { Time = "2010", BMI = 24.3 },
            new Models { Time = "2020", BMI = 27.1 }
        };

        //    string[] arrayclass;

        //public List<Models> Data { get; set; }

        //public ViewModel()
        //{
        //    Data = new List<Models>();


        //    ReadFile();


        //    //string[] arrayclass = { "75", "25", "30", "40" };

        //    //Data = new List<Models>()
        //    //    {
        //    //             new Models { Time = "Leden ", BMI = Double.Parse(arrayclass[0]) },
        //    //             new Models { Time = "Leden ", BMI = Double.Parse(arrayclass[1]) },
        //    //             new Models { Time = "Leden ", BMI = Double.Parse(arrayclass[2]) },
        //    //             new Models { Time = "Leden ", BMI = Double.Parse(arrayclass[3]) }
        //    //        };
        //}


        //public async void ReadFile()
        //{
        //    string mainDir = FileSystem.Current.AppDataDirectory;
        //    string fileName = "notesss.txt";
        //    string filePath = System.IO.Path.Combine(mainDir, fileName);

        //    try
        //    {
        //        using Stream fileStream = await FileSystem.Current.OpenAppPackageFileAsync("BMI.txt");
        //        using StreamReader reader = new StreamReader(fileStream);
        //        string fileContent = await reader.ReadToEndAsync();
        //        arrayclass = fileContent.Split(' ');
        //        //lbl.Text = arrayclass[1] + arrayclass[2] + arrayclass[3];


        //    }
        //    catch (Exception)
        //    {
        //    }
        //}
    }

    }
}

