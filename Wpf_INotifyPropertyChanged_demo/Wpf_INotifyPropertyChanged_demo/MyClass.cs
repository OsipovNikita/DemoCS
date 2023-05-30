using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_INotifyPropertyChanged_demo
{
    /// <summary>
    /// необходимо: 1) сделать класс потомком указанного интерфейса, 
    /// 2) реализовать событие,
    /// 3) написать метод, вызывающий это событие 
    /// 4) во всех свойствах прописать вызов этого метода с передачей имени изменяющегося свойства
    /// </summary>
    public class MyClassProp : INotifyPropertyChanged // 1)
    {
        private string _myString;

        public string MyString
        {
            get
            {
                return _myString;
            }
            set
            {
                if (value != _myString)
                {
                    _myString = value;
                    OnPropertyChanged("MyString");  // 4
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;  // 2)

        protected void OnPropertyChanged(string p_propertyName)     // 3
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(p_propertyName));
            }
        }
    }
}
