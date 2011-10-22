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

namespace Trafikanten.Common.QueryBuilder.Realtime
{
    public class IsUniquePlaceQueryBuilder : IQueryBuilder
    {
        public string Url
        {
            get;
            set;
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

        public IsUniquePlaceQueryBuilder()
        {

        }

        public IsUniquePlaceQueryBuilder(String matchName)
        {
            MatchName = matchName;
        }

        public virtual void BuildUrl()
        {
            if (String.IsNullOrEmpty(MatchName)) return;

            var url = ApiPaths.ApiUrl + ApiPaths.Realtime.IsUniquePlace;

            Url = String.Format(url, MatchName);
        }
    }
}
