using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Location : INotifyPropertyChanged
    {
        private string _name;
        private int _xCoordinate;
        private int _yCoordinate;
        private string _description;
        private string _imageName;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged("Description");
            }
        }

        public string ImageName
        {
            get { return _imageName; }
            set
            {
                _imageName = value;
                OnPropertyChanged("ImageName");
            }
        }

        public int XCoordinate
        {
            get { return _xCoordinate; }
            set
            {
                _xCoordinate = value;
                OnPropertyChanged("XCoordinate");
            }
        }

        public int YCoordinate
        {
            get { return _yCoordinate; }
            set
            {
                _yCoordinate = value;
                OnPropertyChanged("YCoordinate");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
