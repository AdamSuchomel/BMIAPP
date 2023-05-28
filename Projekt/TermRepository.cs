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
                FillTermList();

        }
        public async void FillTermList()
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
