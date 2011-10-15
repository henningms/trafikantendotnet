using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Trafikanten.Place
{
    [DataContract]
    public partial class Place : BaseModel
    {
        private string _zone, _name, _district;
        private string _shortname;
        private long _x, _y, _id;
        private int _type;
        private IList<Stop> _stops;
            
        [DataMember]
        public string Zone
        {
            get
            {
                return _zone; 
            }
            set
            {
                if (_zone == value) return;

                _zone = value;
                NotifyPropertyChanged("Zone");
            }
        }

        [DataMember]
        public long X
        {
            get
            {
                return _x;
            }
            set
            {
                if (_x == value) return;

                _x = value;
                NotifyPropertyChanged("X");
            }
        }

        [DataMember]
        public long Y
        {
            get
            {
                return _y;
            }

            set
            {
                if (_y == value) return;

                _y = value;
                NotifyPropertyChanged("Y");
            }
        }

        [DataMember]
        public long ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id == value) return;

                _id = value;
                NotifyPropertyChanged("ID");
            }
        }

        [DataMember]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name == value) return;

                _name = value;
                NotifyPropertyChanged("Name");
            }
        }

        [DataMember]
        public string District
        {
            get
            {
                return _district;
            }
            set
            {
                if (_district == value) return;

                _district = value;
                NotifyPropertyChanged("District");
            }
        }

        [DataMember]
        public int Type
        {
            get
            {
                return _type;
            }
            set
            {
                if (_type == value) return;

                _type = value;
                NotifyPropertyChanged("Type");
            }
        }

        [DataMember]
        public IList<Stop> Stops
        {
            get
            {
                return _stops;
            }
            set
            {
                if (_stops == value) return;

                _stops = value;
                NotifyPropertyChanged("Stops");
            }
        }

        [DataMember]
        public string ShortName
        {
            get
            {
                return _shortname;
            }
            set
            {
                if (_shortname == value) return;

                _shortname = value;
                NotifyPropertyChanged("ShortName");
            }
        }
    }
}
