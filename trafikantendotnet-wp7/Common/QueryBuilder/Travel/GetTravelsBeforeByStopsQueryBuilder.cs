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

namespace Trafikanten.Common.QueryBuilder.Travel
{
    public class GetTravelsBeforeByStopsQueryBuilder : GetTravelsAfterByStopsQueryBuilder
    {
        public GetTravelsBeforeByStopsQueryBuilder(String time, IEnumerable<int> fromstops, IEnumerable<int> tostops)
        {
            Time = time;

            foreach (var stop in fromstops)
                AddFromStop(stop);

            foreach (var stop in tostops)
                AddToStop(stop);
        }

        public GetTravelsBeforeByStopsQueryBuilder(String time, List<int> fromstops, List<int> tostops)
        {
            Time = time;
            FromStops = fromstops;
            ToStops = tostops;
        }

        public new void BuildUrl()
        {
            if (String.IsNullOrEmpty(Time)) return;
            if (FromStops == null || ToStops == null) return;
            if (FromStops.Count <= 0 || ToStops.Count <= 0) return;

            var url = ApiPaths.ApiUrl + ApiPaths.Travel.GetTravelsBeforeByStops;

            var fromStops = FromStops.Aggregate("", (current, stop) => current + String.Format("{0},", stop));
            var toStops = ToStops.Aggregate("", (current, stop) => current + String.Format("{0},", stop));

            Url = String.Format(url + "?time={0}&fromstops={1}&tostops={2}", Time, fromStops, toStops);
        }
    }
}
