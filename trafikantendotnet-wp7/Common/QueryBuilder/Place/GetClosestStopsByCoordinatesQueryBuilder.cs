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
    public class GetClosestStopsByCoordinatesQueryBuilder : IQueryBuilder
    {
        public string Url
        {
            get;
            set;
        }

        private long _x;
        public long X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
                BuildUrl();
            }
        }

        private long _y;
        public long Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
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

        public GetClosestStopsByCoordinatesQueryBuilder()
        {
            
        }

        public GetClosestStopsByCoordinatesQueryBuilder(long x, long y, int proposals)
        {
            X = x;
            Y = y;
            Proposals = proposals;
        }

        public void BuildUrl()
        {
            var url = ApiPaths.ApiUrl;
            url += ApiPaths.Place.GetClosestStopsByCoordinates;

            url = String.Format(url + "?coordinates=(X={0},Y={1})&proposals={2}", X, Y, Proposals);

            Url = url;
        }
    }
}
