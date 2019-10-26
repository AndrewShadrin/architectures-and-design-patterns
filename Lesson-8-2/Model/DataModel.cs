using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_2
{
    public class DataModel 
    {
        private ObservableCollection<string> data = new ObservableCollection<string>();
        

        public void AddData(string s)
        {
            data.Add(s);
        }

        public ObservableCollection<string> GetAllData()
        {
            return data;
        }
    }
}
