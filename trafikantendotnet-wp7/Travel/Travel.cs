using System;
using System.Collections.ObjectModel;
using System.Net;
using System.Runtime.Serialization;
using Trafikanten.Travelstage;

namespace Trafikanten.Travel
{
    [DataContract]
    public class Travel : BaseModel
    {
        private int _j, _i;
        private DateTime _departureTime, _arrivalTime;
        private ObservableCollection<Remark> _remarks;
        private ObservableCollection<Travelstage.Travelstage> _travelStages;

        [DataMember]
        public int j
        {
            get
            {
                return _j;
            }
            set
            {
                _j = value;
                NotifyPropertyChanged("j");
            }
        }

        [DataMember]
        public int i
        {
            get
            {
                return _i;
            }
            set
            {
                _i = value;
                NotifyPropertyChanged("i");
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
        public ObservableCollection<Remark> Remarks
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

        [DataMember]
        public ObservableCollection<Travelstage.Travelstage> TravelStages
        {
            get
            {
                return _travelStages;
            }
            set
            {
                _travelStages = value;
                NotifyPropertyChanged("TravelStages");
            }
        }
    }
}
