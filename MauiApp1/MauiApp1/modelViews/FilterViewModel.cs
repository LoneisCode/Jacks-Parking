using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MauiApp1.modelViews
{
    class FilterViewModel : INotifyPropertyChanged
    {
        public IList FilterList { get => _FilterList; set { _FilterList = value; OnPropertyChanged(nameof(FilterList)); } }
        private IList _FilterList;
        public event PropertyChangedEventHandler PropertyChanged;

        public FilterViewModel() {
            _FilterList = new List<String>
            {
                "After 5PM",
                "Commutor",
                "Staff",
                "Weekends",
                "Resident",
                "None"
            };
            
        }
         
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
