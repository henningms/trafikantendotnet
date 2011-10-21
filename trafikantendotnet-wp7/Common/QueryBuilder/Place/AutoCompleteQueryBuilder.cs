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
    public class AutoCompleteQueryBuilder : IQueryBuilder
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

        private String _autoCompleteType;
        public String AutoCompleteType
        {
            get
            {
                return _autoCompleteType;
            }
            set
            {
                _autoCompleteType = value;
                BuildUrl();
            }
        }

        public void BuildUrl()
        {
            if (String.IsNullOrEmpty(MatchName)) return;

            var url = ApiPaths.ApiUrl + ApiPaths.Place.Autocomplete;

            url = String.Format(url, MatchName);

            if (!String.IsNullOrEmpty(AutoCompleteType))
                url += String.Format("?autocompleteType={0}", AutoCompleteType);

            Url = url;
        }
    }
}
