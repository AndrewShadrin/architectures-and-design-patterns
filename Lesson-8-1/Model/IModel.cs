using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_1
{
    public interface IModel
    {
        Array GetData();
        void AddData(string s);
        event Action DataChanged;
    }
}
