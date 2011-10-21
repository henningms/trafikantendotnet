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

namespace Trafikanten.Common.QueryBuilder.Place
{
    public class FindMatchesByCountiesQueryBuilder : IQueryBuilder
    {
        public string Url { get; set; }

        private string _matchName;
        public string MatchName
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

        private List<String> _counties;
        public List<String> Counties
        {
            get
            {
                return _counties;
            }
            set
            {
                _counties = value;
                BuildUrl();
            }
        }

        public FindMatchesByCountiesQueryBuilder()
        {
        }

        public FindMatchesByCountiesQueryBuilder(String matchName)
        {
            MatchName = matchName;
        }

        public FindMatchesByCountiesQueryBuilder(String matchName, List<String> counties)
        {
            MatchName = matchName;
            Counties = counties;
        }

        public FindMatchesByCountiesQueryBuilder(String matchName, params String[] counties)
        {
            MatchName = matchName;

            Counties = counties.ToList();
        }

        public void AddCounty(String county)
        {
            if (String.IsNullOrEmpty(county)) return;
            if (Counties == null) Counties = new List<string>();
            if (Counties.Contains(county)) return;

            Counties.Add(county);
            BuildUrl();

        }

        public void RemoveCounty(String county)
        {
            if (String.IsNullOrEmpty(county)) return;
            if (Counties == null) return;

            if (Counties.Contains(county))
                Counties.Remove(county);
        }

        public void BuildUrl()
        {
            if (String.IsNullOrEmpty(MatchName) || Counties == null) return;

            var url = ApiPaths.ApiUrl;
            url += ApiPaths.Place.FindMatchesByCounties;

            url = String.Format(url, MatchName);

            if (Counties.Count > 0)
            {
                url += Counties.Aggregate("?counties=", (current, county) => current + (county + ","));
            }

            Url = url;
        }
    }
}
