using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TestDataTrigger
{
    public class Item
    {
        public Item()
        { }

        public Item(bool isSelected, BitmapImage imgSrc, string name)
        { 
            _isSelected = isSelected;
            _source = imgSrc;
            _name = name;
        }

        private bool _isSelected = false;
        public bool IsSelected
        { 
            get { return _isSelected; }
            set { _isSelected = value; }
        }

        private BitmapImage? _source;
        public BitmapImage? Source
        { 
            set { _source = value; }
            get { return _source; }
        }

        private string _name = "";
        public string Name
        { 
            get { return _name; }
            set { _name = value; }
        }
    }
}
