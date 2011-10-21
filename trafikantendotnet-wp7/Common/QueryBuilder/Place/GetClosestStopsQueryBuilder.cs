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
    public class GetClosestStopsQueryBuilder : IQueryBuilder
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

        private String _street;
        public String Street
        {
            get
            {
                return _street;
            }
            set
            {
                _street = value;
                BuildUrl();
            }
        }

        private int _house;
        public int House
        {
            get
            {
                return _house;
            }
            set
            {
                _house = value;
                BuildUrl();
            }
        }

        private int _proposals;
        public int Proposals
        {
            get
            {
                return _proposals;
            }
            set
            {
                _proposals = value;
                BuildUrl();
            }
        }

        private int _walkingDistance;
        public int WalkingDistance
        {
            get
            {
                return _walkingDistance;
            }
            set
            {
                _walkingDistance = value;
                BuildUrl();
            }
        }

        public GetClosestStopsQueryBuilder() {}

        public GetClosestStopsQueryBuilder(String placeId)
        {
            PlaceId = placeId;
        }

        public GetClosestStopsQueryBuilder(String placeId, String street, int house, int proposals, int walkingDistance)
        {
            PlaceId = placeId;
            Street = street;
            House = house;
            Proposals = proposals;
            WalkingDistance = walkingDistance;
        }

        public void BuildUrl()
        {
            if (String.IsNullOrEmpty(PlaceId) || String.IsNullOrEmpty(Street)) return;

            var url = ApiPaths.ApiUrl;
            url += ApiPaths.Place.GetClosestStops;

            url = String.Format(url + "?street={1}&house={2}&proposals={3}&walkingDistance={4}",
                                PlaceId, Street, House, Proposals, WalkingDistance);

            Url = url;
        }
    }
}
