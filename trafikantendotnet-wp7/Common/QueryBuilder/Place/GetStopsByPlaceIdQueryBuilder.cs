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

namespace Trafikanten.Common.QueryBuilder.Place
{
    public class GetStopsByPlaceIdQueryBuilder : IQueryBuilder
    {
        public string Url
        {
            get;
            set;
        }

        private String _placeId;
        public String PlaceId
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

        public GetStopsByPlaceIdQueryBuilder()
        {
        }

        public GetStopsByPlaceIdQueryBuilder(String placeId)
        {
            PlaceId = placeId;
        }

        public void BuildUrl()
        {
            if (String.IsNullOrEmpty(PlaceId)) return;

            var url = ApiPaths.ApiUrl;
            url += ApiPaths.Place.GetStopsByPlaceId;

            url = String.Format(url, PlaceId);

            Url = url;
        }
    }
}
