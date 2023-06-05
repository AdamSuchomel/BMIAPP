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
            Data = new List<Models>();

            Data.Add(new Models("1990", 21.9));
            Data.Add(new Models("2000", 23.3));
            Data.Add(new Models("2010", 24.3));
            Data.Add(new Models("2020", 27.1));

            //    string[] arrayclass;

            //public List<Models> Data { get; set; }

            //public ViewModel()
            //{
            //    Data = new List<Models>();



            //    ReadFile();
            //}
            //public async void ReadFile()
            //{
            //    string mainDir = FileSystem.Current.AppDataDirectory;
            //    string fileName = "bmi.txt";
            //    string filePath = System.IO.Path.Combine(mainDir, fileName);


            //    Stream fileStream = System.IO.File.OpenRead(filePath);
            //    StreamReader reader = new StreamReader(fileStream);
            //    string fileContent = await reader.ReadToEndAsync();
            //    string[] arrayclass = fileContent.Split('\n');

            //    foreach (var item in arrayclass)
            //    {
            //        Data.Add(new Models("Leden ", Double.Parse(item)));

            //    }


            //}
        }
    }
}

