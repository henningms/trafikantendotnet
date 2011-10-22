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
    public class FindMatchesQueryBuilder : IQueryBuilder
    {
        public String Url { get; set; }

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

        public FindMatchesQueryBuilder() { }

        public FindMatchesQueryBuilder(string matchName)
        {
            MatchName = matchName;
        }

        public virtual void BuildUrl()
        {
            var url = ApiPaths.ApiUrl;

            url += ApiPaths.Place.FindMatches;

            Url = String.Format(url, MatchName);
        }
    }
}
