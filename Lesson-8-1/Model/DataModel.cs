using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_1
{
    public class DataModel : IModel
    {
        private List<string> data = new List<string>();
        
        public event Action DataChanged;

        public void AddData(string s)
        {
            data.Add(s);
            DataChanged?.Invoke();
        }

        public Array GetData()
        {
            return data.ToArray<string>();
        }
    }
}
