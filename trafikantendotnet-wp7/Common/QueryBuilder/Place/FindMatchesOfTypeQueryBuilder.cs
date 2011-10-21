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
    public class FindMatchesOfTypeQueryBuilder : IQueryBuilder
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

        private String _type;
        public String Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
                BuildUrl();
            }
        }

        public FindMatchesOfTypeQueryBuilder() {}

        public FindMatchesOfTypeQueryBuilder(String matchName)
        {
            MatchName = matchName;
        }

        public FindMatchesOfTypeQueryBuilder(String matchName, String type)
        {
            MatchName = matchName;
            Type = type;
        }

        public void BuildUrl()
        {
            if (String.IsNullOrEmpty(MatchName) || String.IsNullOrEmpty(Type)) return;

            var url = ApiPaths.ApiUrl;
            url += ApiPaths.Place.FindMatchesOfType;

            url = String.Format(url, MatchName);

            url += "?placeType=" + Type;

            Url = url;

        }
    }
}
