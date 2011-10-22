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

namespace Trafikanten.Common.QueryBuilder.Street
{
    public class GetStreetsQueryBuilder : Place.FindMatchesQueryBuilder
    {
        public GetStreetsQueryBuilder()
        {
            
        }

        public GetStreetsQueryBuilder(String matchName)
        {
            MatchName = matchName;
        }

        public override void BuildUrl()
        {
            if (String.IsNullOrEmpty(MatchName)) return;

            var url = ApiPaths.ApiUrl + ApiPaths.Street.GetStreets;

            Url = String.Format(url, MatchName);
        }
    }
}
