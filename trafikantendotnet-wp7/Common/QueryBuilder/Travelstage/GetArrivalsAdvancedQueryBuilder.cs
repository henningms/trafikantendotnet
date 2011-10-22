using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Trafikanten.Common.QueryBuilder.Travelstage
{
    public class GetArrivalsAdvancedQueryBuilder : GetArrivalsQueryBuilder
    {
        private List<String> _lines;
        public List<String> Lines
        {
            get
            {
                return _lines;
            }
            set
            {
                _lines = value;
                BuildUrl();
            }
        }

        private List<String> _transporttypes;
        public List<String> TransportTypes
        {
            get
            {
                return _transporttypes;
            }
            set
            {
                _transporttypes = value;
                BuildUrl();
            }
        }

        public GetArrivalsAdvancedQueryBuilder()
        {
            
        }

        public GetArrivalsAdvancedQueryBuilder(int placeId, String time, List<String> lines, List<String> transporttypes)
        {
            PlaceId = placeId;
            Time = time;
            Lines = lines;
            TransportTypes = transporttypes;
        }

        public override void BuildUrl()
        {
            if (String.IsNullOrEmpty(Time)) return;

            if (Lines == null || Lines.Count <= 0)
            {
                Lines = new List<string> {String.Empty};
            }

            if (TransportTypes == null || TransportTypes.Count <= 0)
            {
                TransportTypes = new List<string> {"Walking,AirportBus,Bus,Dummy,AirportTrain,Boat,Train,Tram,Metro"};
            }

            var transport = TransportTypes.Aggregate("", (current, type) => current + String.Format("{0},", type));
            var lines = Lines.Aggregate("", (current, line) => current + String.Format("{0},", line));

            if (lines.EndsWith(","))
                lines.Remove(lines.Length - 1);

            if (transport.EndsWith(","))
                transport.Remove(transport.Length - 1);

            var url = ApiPaths.ApiUrl + ApiPaths.Travelstage.GetArrivalsAdvanced;

            Url = String.Format(url + "{0}?time={1}&lines={2}&transporttypes={3}", PlaceId, Time, lines, transport);
        }


    }
}
