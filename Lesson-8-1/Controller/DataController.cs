using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_1
{
    public class DataController : IController
    {
        private IModel model;

        public DataController(IModel model)
        {
            if (model == null)
            {
                throw new NullReferenceException("Model not present");
            }
            this.model = model;
        }
        public void AddData(string s)
        {
            model.AddData(s);
        }
    }
}
