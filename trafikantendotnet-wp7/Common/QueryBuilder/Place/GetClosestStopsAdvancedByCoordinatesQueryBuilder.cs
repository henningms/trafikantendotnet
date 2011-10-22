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
    public class GetClosestStopsAdvancedByCoordinatesQueryBuilder : GetClosestStopsByCoordinatesQueryBuilder
    {
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

        public override void BuildUrl()
        {
            base.BuildUrl();

            Url = String.Format(Url + "&walkingDistance={0}", WalkingDistance);
        }
        
    }
}
