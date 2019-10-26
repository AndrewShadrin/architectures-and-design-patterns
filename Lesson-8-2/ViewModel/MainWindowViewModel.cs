using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;

namespace Lesson_8_2
{
    public class ViewModel : INotifyPropertyChanged, IDisposable
    {
        private string newString;

        public string NewString
        {
            get { return newString}
            set { newString = value; OnPropertyChanged(nameof(NewString)); }
        }
        public ICommand addCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
