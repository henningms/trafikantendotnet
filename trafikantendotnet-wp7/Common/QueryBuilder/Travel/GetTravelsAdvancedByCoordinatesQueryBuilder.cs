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
    public class GetTravelsAdvancedByCoordinatesQueryBuilder : GetTravelsAdvancedQueryBuilder
    {
        private long _fromX;
        public long FromX
        {
            get
            {
                return _fromX;
            }
            set
            {
                _fromX = value;
                BuildUrl();
            }
        }

        private long _fromYy;
        private long FromY
        {
            get
            {
                return _fromYy;
            }
            set
            {
                _fromYy = value;
                BuildUrl();
            }
        }

        private long _toX;
        public long ToX
        {
            get
            {
                return _toX;
            }
            set
            {
                _toX = value;
                BuildUrl();
            }
        }

        private long _toY;
        private long ToY
        {
            get
            {
                return _toY;
            }
            set
            {
                _toY = value;
                BuildUrl();
            }
        }

        public GetTravelsAdvancedByCoordinatesQueryBuilder(String time, long fromX, long fromY, long toX, long toY, int changeMargin, int changePunish,
                int walkingFactor, Boolean isAfter, int proposals, List<String> transporttypes)
        {
            Time = time;
            FromX = fromX;
            FromY = fromY;
            ToX = toX;
            ToY = toY;
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

            var param =
                String.Format(
                    "?time={0}&fromcoordinates=(X={1}, Y={9})&tocoordinates=(X={2}, Y={10})&changeMargin={3}&changePunish={4}&walkingFactor={5}&isAfter={6}&proposals={7}&transporttypes={8}",
                    Time, FromX, ToX, ChangeMargin, ChangePunish, WalkingFactor, IsAfter, Proposals, transport, FromY,
                    ToY);

            Url = url + param;
        }
    }
}
