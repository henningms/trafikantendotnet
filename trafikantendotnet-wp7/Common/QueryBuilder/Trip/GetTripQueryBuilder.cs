using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Trafikanten.Common.QueryBuilder.Trip
{
    public class GetTripQueryBuilder : Travelstage.GetArrivalsQueryBuilder
    {
        public GetTripQueryBuilder()
        {
            
        }

        public GetTripQueryBuilder(int placeId, String time)
        {
            PlaceId = placeId;
            Time = time;
        }

        public new void BuildUrl()
        {
            if (String.IsNullOrEmpty(Time)) return;

            var url = ApiPaths.ApiUrl + ApiPaths.Trip.GetTrip;

            Url = String.Format(url + "{0}?time={1}", PlaceId, Time);
        }
    }
}
