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

namespace Trafikanten.Common.QueryBuilder.Realtime
{
    public class GetRealTimeDataQueryBuilder : IQueryBuilder
    {
        public string Url
        {
            get;
            set;
        }

        private long _placeId;
        public long PlaceId
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

        public GetRealTimeDataQueryBuilder()
        {
            
        }

        public GetRealTimeDataQueryBuilder(long placeId)
        {
            PlaceId = placeId;
        }

        public void BuildUrl()
        {
            var url = ApiPaths.ApiUrl + ApiPaths.Realtime.GetRealTimeData;

            Url = String.Format(url, PlaceId);
        }
    }
}
