using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace TestDataTrigger
{
    public class TestTriggerViewModel : PropertyChangeBase
    {
        private ObservableCollection<Item>? _items;
        public ObservableCollection<Item> Items 
        {
            set 
            { 
                _items = value;
                OnPropertyChanged("Items");
            }
            get { return _items; } 
        }
    }
}
