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

namespace Trafikanten.Common.QueryBuilder.Travelstage
{
    public class GetArrivalsQueryBuilder : IQueryBuilder
    {
        public string Url
        {
            get;
            set;
        }

        private int _placeId;
        public int PlaceId
        {
            get
            {
                return _placeId;
            }
            set
            {
                _placeId = value;
                BuildUrl();
            }
        }

        private String _time;
        public String Time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = value;
                BuildUrl();
            }
        }

        public GetArrivalsQueryBuilder()
        {
            
        }

        public GetArrivalsQueryBuilder(int placeId, String time)
        {
            PlaceId = placeId;
            Time = time;
        }

        public void BuildUrl()
        {
            if (String.IsNullOrEmpty(Time)) return;

            var url = ApiPaths.ApiUrl + ApiPaths.Travelstage.GetArrivals;

            Url = String.Format(url + "{0}?time={1}", PlaceId, Time);
        }
    }
}
