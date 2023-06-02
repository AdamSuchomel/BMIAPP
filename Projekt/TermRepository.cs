using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class TermRepository
    {
        public ObservableCollection<Term> _list;

        public ObservableCollection<Term> TheList
        {
            get { return _list; }
            set { _list = value; }
        }

        public TermRepository()
        {
                _list = new ObservableCollection<Term>();

#if WINDOWS
                FillTermListPC();
#elif ANDROID
            FillTermListAndroid();
#endif

        }


        public void FillTermListAndroid()
        {
            String line;
            string mainDir = FileSystem.Current.AppDataDirectory;
            string fileName = "notesss.txt";
            string filePath = System.IO.Path.Combine(mainDir, fileName);

            Term aTerm = new Term();

            try
            {
                using Stream fileStream = System.IO.File.OpenRead(filePath);
                using StreamReader sr = new StreamReader(fileStream);
                while ((line = sr.ReadLine()) != null)
                {
                    aTerm = new Term();
                    aTerm.TheTerm = line;
                    _list.Add(aTerm);
                }
            }
            catch (Exception ex)
            {
                Term error = new Term();
                error.TheTerm = ex.ToString();
                _list.Add(error);
                
            }
        }

        public async void FillTermListPC()
        {
            String line;
            Term aTerm = new Term();

            try
            {
                using Stream fileStream = await FileSystem.Current.OpenAppPackageFileAsync("notesss.txt");
                using StreamReader sr = new StreamReader(fileStream);
                while ((line = sr.ReadLine()) != null)
                {
                    aTerm = new Term();
                    aTerm.TheTerm = line;
                    _list.Add(aTerm);
                }
            }
            catch (Exception ex)
            {
                Term error = new Term();
                error.TheTerm = ex.ToString();
                _list.Add(error);

            }
        }

    }
}
