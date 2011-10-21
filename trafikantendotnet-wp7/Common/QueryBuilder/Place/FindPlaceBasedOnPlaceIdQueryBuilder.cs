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
    public class FindPlaceBasedOnPlaceIdQueryBuilder : IQueryBuilder
    {
        public string Url
        {
            get;
            set;
        }

        private String _placeId;
        public String PlaceID
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

        private String _matchName;
        public String MatchName
        {
            get
            {
                return _matchName;
            }
            set
            {
                _matchName = value;
                BuildUrl();
            }
        }

        public FindPlaceBasedOnPlaceIdQueryBuilder()
        {
        }

        public FindPlaceBasedOnPlaceIdQueryBuilder(String placeId)
        {
            PlaceID = placeId;
        }

        public FindPlaceBasedOnPlaceIdQueryBuilder(String placeId, String matchName)
        {
            PlaceID = placeId;
            MatchName = matchName;
        }

        public void BuildUrl()
        {
            if (String.IsNullOrEmpty(PlaceID) || String.IsNullOrEmpty(MatchName)) return;

            var url = ApiPaths.ApiUrl;
            url += ApiPaths.Place.FindPlaceBasedOnPlaceId;

            url = String.Format(url + "{1}", PlaceID, "?search=" + MatchName);

            Url = url;
        }
    }
}
