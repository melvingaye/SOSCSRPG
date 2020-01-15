using Engine.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Location : BaseNotificationClass
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
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        public string ImageName
        {
            get { return _imageName; }
            set
            {
                _imageName = value;
                OnPropertyChanged(nameof(ImageName));
            }
        }

        public int XCoordinate
        {
            get { return _xCoordinate; }
            set
            {
                _xCoordinate = value;
                OnPropertyChanged(nameof(XCoordinate));
            }
        }

        public int YCoordinate
        {
            get { return _yCoordinate; }
            set
            {
                _yCoordinate = value;
                OnPropertyChanged(nameof(YCoordinate));
            }
        }
    }
}
