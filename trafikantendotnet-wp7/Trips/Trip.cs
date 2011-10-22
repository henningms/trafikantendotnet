using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Trafikanten.Common;


namespace Trafikanten.Trips
{
    [DataContract]
    public class Trip : BaseModel
    {
        private int _id;
        private ObservableCollection<Stop> _stops;

        [DataMember]
        public ObservableCollection<Stop> Stops
        {
            get
            {
                return _stops;
            }
            set
            {
                _stops = value;
                NotifyPropertyChanged("Stops");
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
    }
}
