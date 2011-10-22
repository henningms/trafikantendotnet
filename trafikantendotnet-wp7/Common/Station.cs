using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Runtime.Serialization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Trafikanten.Common
{
    [DataContract]
    public class Station : BaseModel
    {
        private DateTime _recordedAtTime, _aimedArrivalTime, _expectedArrivalTime;
        private DateTime _aimedDepartureTime, _expectedDepartureTime;
        private string _publishedLineName, _directionName, _lineRef, _directionRef;
        private string _operatorRef, _destinationName, _departurePlatformName;
        private string _blockRef, _destinationDisplay, _stopPointName;
        private string _monitoringRef, _delay, _progressStatus;
        private string _vehicleRef, _nextStopPointName, _stopVisitNote;
        private string _vehicleFeatureRef, _vehicleFeature, _vehicleAtStop;
        private string _inCongestion, _destinationRef, _originName, _originRef;
        private string _vehicleMode, _arrivalPlatformName;
        private bool? _monitored;
        private int _visitNumber;
        private ObservableCollection<VehicleJourneyRef> _framedVehicleJourneyRef;
        private ObservableCollection<TrainBlocks> _trainBlockPart;
            
       [DataMember]
        public DateTime RecordedAtTime
        {
            get
            {
                return _recordedAtTime;
            }
            set
            {
                _recordedAtTime = value;
                NotifyPropertyChanged("RecordedAtTime");
            }
        }

        [DataMember]
        public string PublishedLineName
        {
            get
            {
                return _publishedLineName;
            }
            set
            {
                _publishedLineName = value;
                NotifyPropertyChanged("PublishedLineName");
            }
        }

        [DataMember]
        public string DirectionName
        {
            get
            {
                return _directionName;
            }
            set
            {
                _directionName = value;
                NotifyPropertyChanged("DirectionName");
            }
        }

        [DataMember]
        public string LineRef
        {
            get
            {
                return _lineRef;
            }
            set
            {
                _lineRef = value;
                NotifyPropertyChanged("LineRef");
            }
        }

        [DataMember]
        public string DirectionRef
        {
            get
            {
                return _directionRef;
            }
            set
            {
                _directionRef = value;
                NotifyPropertyChanged("DirectionRef");
            }
        }

        [DataMember]
        public string OperatorRef
        {
            get
            {
                return _operatorRef;
            }
            set
            {
                _operatorRef = value;
                NotifyPropertyChanged("OperatorRef");
            }
        }

        [DataMember]
        public string DestinationName
        {
            get
            {
                return _destinationName;
            }
            set
            {
                _destinationName = value;
                NotifyPropertyChanged("DestinationName");
            }
        }

        [DataMember]
        public bool? Monitored
        {
            get
            {
                return _monitored;
            }
            set
            {
                _monitored = value;
                NotifyPropertyChanged("Monitored");
            }
        }

        [DataMember]
        public int VisitNumber
        {
            get
            {
                return _visitNumber;
            }
            set
            {
                _visitNumber = value;
                NotifyPropertyChanged("VisitNumber");
            }
        }

        [DataMember]
        public DateTime AimedArrivalTime
        {
            get
            {
                return _aimedArrivalTime;
            }
            set
            {
                _aimedArrivalTime = value;
                NotifyPropertyChanged("AimedArrivalTime");
            }
        }

        [DataMember]
        public DateTime ExpectedArrivalTime
        {
            get
            {
                return _expectedArrivalTime;
            }
            set
            {
                _expectedArrivalTime = value;
                NotifyPropertyChanged("ExpectedArrivalTime");
            }
        }

        [DataMember]
        public string ArrivalPlatformName
        {
            get
            {
                return _arrivalPlatformName
            }
            set
            {
                _arrivalPlatformName = value;
                NotifyPropertyChanged("ArrivalPlatformName");
            }
        }

        [DataMember]
        public DateTime AimedDepartureTime
        {
            get
            {
                return _aimedDepartureTime;
            }
            set
            {
                _aimedDepartureTime = value;
                NotifyPropertyChanged("AimedDepartureTime");
            }
        }

        [DataMember]
        public DateTime ExpectedDepartureTime
        {
            get
            {
                return _expectedDepartureTime;
            }
            set
            {
                _expectedDepartureTime = value;
                NotifyPropertyChanged("ExpectedDepartureTime");
            }
        }

        [DataMember]
        public string DeparturePlatformName
        {
            get
            {
                return _departurePlatformName;
            }
            set
            {
                _departurePlatformName = value;
                NotifyPropertyChanged("DeparturePlatformName");
            }
        }

        [DataMember]
        public string BlockRef
        {
            get
            {
                return _blockRef;
            }
            set
            {
                _blockRef = value;
                NotifyPropertyChanged("BlockRef");
            }
        }

        [DataMember]
        public string DestinationDisplay
        {
            get
            {
                return _destinationDisplay;
            }
            set
            {
                _destinationDisplay = value;
                NotifyPropertyChanged("DestinationDisplay");
            }
        }

        [DataMember]
        public string StopPointName
        {
            get
            {
                return _stopPointName;
            }
            set
            {
                _stopPointName = value;
                NotifyPropertyChanged("StopPointName");
            }
        }

        [DataMember]
        public string MonitoringRef
        {
            get
            {
                return _monitoringRef;
            }
            set
            {
                _monitoringRef = value;
                NotifyPropertyChanged("MonitoringRef");
            }
        }

        [DataMember]
        public string Delay
        {
            get
            {
                return _delay;
            }
            set
            {
                _delay = value;
                NotifyPropertyChanged("Delay");
            }
        }

        [DataMember]
        public string ProgressStatus
        {
            get
            {
                return _progressStatus;
            }
            set
            {
                _progressStatus = value;
                NotifyPropertyChanged("ProgressStatus");
            }
        }

        [DataMember]
        public string VehicleRef
        {
            get
            {
                return _vehicleRef;
            }
            set
            {
                _vehicleRef = value;
                NotifyPropertyChanged("VehicleRef");
            }
        }

        [DataMember]
        public string NextStopPointName
        {
            get
            {
                return _nextStopPointName;
            }
            set
            {
                _nextStopPointName = value;
                NotifyPropertyChanged("NextStopPointName");
            }
        }

        [DataMember]
        public string StopVisitNote
        {
            get
            {
                return _stopVisitNote;
            }
            set
            {
                _stopVisitNote = value;
                NotifyPropertyChanged("StopVisitNote");
            }
        }

        [DataMember]
        public ObservableCollection<VehicleJourneyRef> FramedVehicleJourneyRef
        {
            get
            {
                return _framedVehicleJourneyRef;
            }
            set
            {
                _framedVehicleJourneyRef = value;
                NotifyPropertyChanged("FramedVehicleJourneyRef");
            }
        }

        [DataMember]
        public string VehicleFeatureRef
        {
            get
            {
                return _vehicleFeatureRef;
            }
            set
            {
                _vehicleFeatureRef = value;
                NotifyPropertyChanged("VehicleFeatureRef");
            }
        }

        [DataMember]
        public ObservableCollection<TrainBlocks> TrainBlockPart
        {
            get
            {
                return _trainBlockPart;
            }
            set
            {
                _trainBlockPart = value;
                NotifyPropertyChanged("TrainBlockPart");
            }
        }
        [DataMember]
        public string VehicleFeature
        {
            get
            {
                return _vehicleFeature;
            }
            set
            {
                _vehicleFeature = value;
                NotifyPropertyChanged("VehicleFeature");
            }
        }

        [DataMember]
        public string VehicleAtStop
        {
            get
            {
                return _vehicleAtStop;
            }
            set
            {
                _vehicleAtStop = value;
                NotifyPropertyChanged("VehicleAtStop");
            }
        }

        [DataMember]
        public string InCongestion
        {
            get
            {
                return _inCongestion;
            }
            set
            {
                _inCongestion = value;
                NotifyPropertyChanged("InCongestion");
            }
        }
        [DataMember]
        public string DestinationRef
        {
            get
            {
                return _destinationRef;
            }
            set
            {
                _destinationRef = value;
                NotifyPropertyChanged("DestinationRef");
            }
        }

        [DataMember]
        public string OriginName
        {
            get
            {
                return _originName;
            }
            set
            {
                _originName = value;
                NotifyPropertyChanged("OriginName");
            }
        }

        [DataMember]
        public string OriginRef
        {
            get
            {
                return _originRef;
            }
            set
            {
                _originRef = value;
                NotifyPropertyChanged("OriginRef");
            }
        }

        [DataMember]
        public string VehicleMode
        {
            get
            {
                return _vehicleMode;
            }
            set
            {
                _vehicleMode = value;
                NotifyPropertyChanged("VehicleMode");
            }
        }
    }

    [DataContract]
    public class VehicleJourneyRef : BaseModel
    {
        private string _dataFrameRef, _datedVehicleJourneyRef;

        [DataMember]
        public string DataFrameRef
        {
            get
            {
                return _dataFrameRef;
            }
            set
            {
                _dataFrameRef = value;
                NotifyPropertyChanged("DataFrameRef");
            }
        }

        [DataMember]
        public string DatedVehicleJourneyRef
        {
            get
            {
                return _datedVehicleJourneyRef;
            }
            set
            {
                _datedVehicleJourneyRef = value;
                NotifyPropertyChanged("DatedVehicleJourneyRef");
            }
        }
    }

    [DataContract]
    public class TrainBlocks : BaseModel
    {
        private int _numberOfBlockParts;

        [DataMember]
        public int NumberOfBlockParts
        {
            get
            {
                return _numberOfBlockParts;
            }
            set
            {
                _numberOfBlockParts = value;
                NotifyPropertyChanged("NumberOfBlockParts");
            }
        }
    }
}
