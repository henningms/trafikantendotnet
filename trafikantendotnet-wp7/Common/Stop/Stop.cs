using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Runtime.Serialization;
using Trafikanten.Places;

namespace Trafikanten.Common
{
    public class Stop : Place
    {
        private int _walkingdistance, _rank;
        private bool? _alightingAllowed, _boardingAllowed;
        private bool? _realtimestop;
        private DateTime _departureTime, _arrivalTime;
        private ObservableCollection<Line> _lines;
        private ObservableCollection<StopPoint> _stopPoints;

        [DataMember]
        public int WalkingDistance
        {
            get
            {
                return _walkingdistance;
            }
            set
            {
                if (_walkingdistance == value) return;

                _walkingdistance = value;
                NotifyPropertyChanged("WalkingDistance");
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
                if (_arrivalTime == value) return;

                _arrivalTime = value;
                NotifyPropertyChanged("ArrivalTime");
            }
        }

        [DataMember]
        public bool? AlightingAllowed
        {
            get
            {
                return _alightingAllowed;
            }
            set
            {
                if (_alightingAllowed == value) return;

                _alightingAllowed = value;
                NotifyPropertyChanged("AlightingAllowed");
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
                if (_departureTime == value) return;

                _departureTime = value;
                NotifyPropertyChanged("DepartureTime");
            }
        }

        [DataMember]
        public bool? BoardingAllowed
        {
            get
            {
                return _boardingAllowed;
            }
            set
            {
                if (_boardingAllowed == value) return;

                _boardingAllowed = value;
                NotifyPropertyChanged("BoardingAllowed");
            }
        }

        [DataMember]
        public bool? RealTimeStop
        {
            get
            {
                return _realtimestop;
            }
            set
            {
                if (_realtimestop == value) return;

                _realtimestop = value;
                NotifyPropertyChanged("RealTimeStop");
            }
        }

        [DataMember]
        public int Rank
        {
            get
            {
                return _rank;
            }
            set
            {
                if (_rank == value) return;

                _rank = value;
                NotifyPropertyChanged("Rank");
            }
        }

        [DataMember]
        public ObservableCollection<Line> Lines
        {
            get
            {
                return _lines;
            }
            set
            {
                if (_lines == value) return;

                _lines = value;
                NotifyPropertyChanged("Lines");
            }
        }

        [DataMember]
        public ObservableCollection<StopPoint> StopPoints
        {
            get
            {
                return _stopPoints;
            }
            set
            {
                if (_stopPoints == value) return;

                _stopPoints = value;
                NotifyPropertyChanged("StopPoints");
            }
        }
    }
}
