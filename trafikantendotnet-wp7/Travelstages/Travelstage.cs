using System;
using System.Net;
using System.Runtime.Serialization;
using Trafikanten.Common;
using Trafikanten.Travels;

namespace Trafikanten.Travelstages
{
    [DataContract]
    public class Travelstage : BaseModel
    {
        private int _id;
        private int _departureWalkingDistance;
        private int _arrivalWalkingDistance;
        private DateTime _departureTime;
        private DateTime _actualTime;
        private DateTime _arrivalTime;
        private Stop _departureStop;
        private Stop _actualStop;
        private Stop _arrivalStop;
        private string _destination;
        private string _lineName;
        private int _lineId;
        private int _tourId;
        private int _transportation;
        private Remark _remarks;

        [DataMember]
        public int Transportation
        {
            get
            {
                return _transportation;
            }
            set
            {
                _transportation = value;
                NotifyPropertyChanged("Transportation");
            }
        }

        [DataMember]
        public int LineID
        {
            get
            {
                return _lineId;
            }
            set
            {
                _lineId = value;
                NotifyPropertyChanged("LineID");
            }
        }

        [DataMember]
        public int TourID
        {
            get
            {
                return _tourId;
            }
            set
            {
                _tourId = value;
                NotifyPropertyChanged("TourID");
            }
        }

        [DataMember]
        public string Destination
        {
            get
            {
                return _destination;
            }
            set
            {
                _destination = value;
                NotifyPropertyChanged("Destination");
            }
        }

        [DataMember]
        public string LineName
        {
            get
            {
                return _lineName;
            }
            set
            {
                _lineName = value;
                NotifyPropertyChanged("LineName");
            }
        }

        [DataMember]
        public Stop DepartureStop
        {
            get
            {
                return _departureStop;
            }
            set
            {
                _departureStop = value;
                NotifyPropertyChanged("DepartureStop");
            }
        }

        [DataMember]
        public Stop ActualStop
        {
            get
            {
                return _actualStop;
            }
            set
            {
                _actualStop = value;
                NotifyPropertyChanged("ActualStop");
            }
        }

        [DataMember]
        public Stop ArrivalStop
        {
            get
            {
                return _arrivalStop;
            }
            set
            {
                _arrivalStop = value;
                NotifyPropertyChanged("ArrivalStop");
            }
        }

        [DataMember]
        public DateTime DepartureTime
        {
            get
            {
                return _departureTime;
            }
            set
            {
                _departureTime = value;
                NotifyPropertyChanged("DepartureTime");
            }
        }

        [DataMember]
        public DateTime ActualTime
        {
            get
            {
                return _actualTime;
            }
            set
            {
                _actualTime = value;
                NotifyPropertyChanged("ActualTime");
            }
        }

        [DataMember]
        public DateTime ArrivalTime
        {
            get
            {
                return _arrivalTime;
            }
            set
            {
                _arrivalTime = value;
                NotifyPropertyChanged("ArrivalTime");
            }
        }

        [DataMember]
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                NotifyPropertyChanged("ID");
            }
        }

        [DataMember]
        public int DepartureWalkingDistance
        {
            get
            {
                return _departureWalkingDistance;
            }
            set
            {
                _departureWalkingDistance = value;
                NotifyPropertyChanged("DepartureWalkingDistance");
            }
        }

        [DataMember]
        public int ArrivalWalkingDistance
        {
            get
            {
                return _arrivalWalkingDistance;
            }
            set
            {
                _arrivalWalkingDistance = value;
                NotifyPropertyChanged("ArrivalWalkingDistance");
            }
        }

        [DataMember]
        public Remark Remarks
        {
            get
            {
                return _remarks;
            }
            set
            {
                _remarks = value;
                NotifyPropertyChanged("Remarks");
            }
        }
    }
}
