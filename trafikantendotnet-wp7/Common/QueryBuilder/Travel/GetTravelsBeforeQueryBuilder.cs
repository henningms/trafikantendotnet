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

namespace Trafikanten.Common.QueryBuilder.Travel
{
    public class GetTravelsBeforeQueryBuilder : GetTravelsAfterQueryBuilder
    {
        public GetTravelsBeforeQueryBuilder()
        {
            
        }

        public GetTravelsBeforeQueryBuilder(String time, int from, int to)
        {
            Time = time;
            From = from;
            To = to;
        }

        public new void BuildUrl()
        {
            if (String.IsNullOrEmpty(Time)) return;

            var url = ApiPaths.ApiUrl + ApiPaths.Travel.GetTravelsBefore;

            Url = String.Format(url + "time={0}&from={1}&to={2}", Time, From, To);
        }
    }
}
