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
    public class GetTravelsAdvancedQueryBuilder : GetTravelsAfterByStopsQueryBuilder
    {
        private int _changeMargin;
        public int ChangeMargin
        {
            get
            {
                return _changeMargin;
            }
            set
            {
                _changeMargin = value;
                BuildUrl();
            }
        }

        private int _changePunish;
        public int ChangePunish
        {
            get
            {
                return _changePunish;
            }
            set
            {
                _changePunish = value;
                BuildUrl();
            }
        }

        private int _walkingFactor;
        public int WalkingFactor
        {
            get
            {
                return _walkingFactor;
            }
            set
            {
                _walkingFactor = value;
                BuildUrl();
            }
        }

        private Boolean _isAfter;
        public Boolean IsAfter
        {
            get
            {
                return _isAfter;
            }
            set
            {
                _isAfter = value;
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

        private List<String> _transportTypes;
        public List<String> TransportTypes
        {
            get
            {
                return _transportTypes;
            }
            set
            {
                _transportTypes = value;
                BuildUrl();
            }
        }

        public GetTravelsAdvancedQueryBuilder()
        {
            
        }

        public GetTravelsAdvancedQueryBuilder(String time, List<int> fromstops, List<int> tostops, int changeMargin, int changePunish,
                int walkingFactor, Boolean isAfter, int proposals, List<String> transporttypes)
        {
            Time = time;
            FromStops = fromstops;
            ToStops = tostops;
            ChangeMargin = changeMargin;
            ChangePunish = changePunish;
            WalkingFactor = walkingFactor;
            IsAfter = isAfter;
            Proposals = proposals;
            TransportTypes = transporttypes;
        }

        public override void BuildUrl()
        {
            if (String.IsNullOrEmpty(Time)) return;
            if (FromStops == null || ToStops == null) return;
            if (FromStops.Count <= 0 || ToStops.Count <= 0) return;

            var url = ApiPaths.ApiUrl + ApiPaths.Travel.GetTravelsAdvanced;

            var transport = TransportTypes.Aggregate("", (current, type) => current + String.Format("{0},", type));
            var fromStops = FromStops.Aggregate("", (current, stop) => current + String.Format("{0},", stop));
            var toStops = ToStops.Aggregate("", (current, stop) => current + String.Format("{0},", stop));

            var param =
                String.Format(
                    "?time={0}&fromstops={1}&tostops={2}&changeMargin={3}&changePunish={4}&walkingFactor={5}&isAfter={6}&proposals={7}&transporttypes={8}", 
                        Time, fromStops, toStops, ChangeMargin, ChangePunish, WalkingFactor, IsAfter, Proposals, transport);

            Url = url + param;

        }
    }
}
