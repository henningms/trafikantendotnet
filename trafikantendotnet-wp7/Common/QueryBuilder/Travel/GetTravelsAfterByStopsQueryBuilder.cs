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
    public class GetTravelsAfterByStopsQueryBuilder : GetTravelsAfterQueryBuilder
    {
        private List<int> _fromStops;
        public List<int> FromStops
        {
            get
            {
                return _fromStops;
            }
            set
            {
                _fromStops = value;
                BuildUrl();
            }
        }

        private List<int> _toStops;
        public List<int> ToStops
        {
            get
            {
                return _toStops;
            }
            set
            {
                _toStops = value;
                BuildUrl();
            }
        }

        public GetTravelsAfterByStopsQueryBuilder()
        {
            
        }

        public GetTravelsAfterByStopsQueryBuilder(String time, int[] fromstops, int[] tostops)
        {
            Time = time;

            foreach (var stop in tostops)
            {
                AddToStop(stop);
            }

            foreach (var stop in fromstops)
            {
                AddFromStop(stop);
            }
        }

        public void AddToStop(int stop)
        {
            if (ToStops == null) ToStops = new List<int>();

            ToStops.Add(stop);
            BuildUrl();
        }

        public void RemoveToStop(int stop)
        {
            if (ToStops == null) return;

            ToStops.Remove(stop);
            BuildUrl();
        }

        public void RemoveFromStop(int stop)
        {
            if (FromStops == null) return;

            FromStops.Remove(stop);
            BuildUrl();
        }

        public void AddFromStop(int stop)
        {
            if (FromStops == null) FromStops = new List<int>();

            FromStops.Add(stop);
            BuildUrl();
        }

        public override void BuildUrl()
        {
            if (String.IsNullOrEmpty(Time)) return;
            if (FromStops == null || ToStops == null) return;
            if (FromStops.Count <= 0 || ToStops.Count <= 0) return;

            var url = ApiPaths.ApiUrl + ApiPaths.Travel.GetTravelsAfterByStops;

            var fromStops = FromStops.Aggregate("", (current, stop) => current + String.Format("{0},", stop));
            var toStops = ToStops.Aggregate("", (current, stop) => current + String.Format("{0},", stop));

            Url = String.Format(url + "?time={0}&fromstops={1}&tostops={2}", Time, fromStops, toStops);
        }
    }
}
