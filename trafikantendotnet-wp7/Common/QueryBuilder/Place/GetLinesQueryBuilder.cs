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
    public class GetLinesQueryBuilder : IQueryBuilder
    {
        public string Url
        {
            get;
            set;
        }

        private int _lineId;
        public int LineId
        {
            get
            {
                return _lineId;
            }
            set
            {
                _lineId = value;
                BuildUrl();
            }
        }

        public GetLinesQueryBuilder()
        {
        }
        
        public GetLinesQueryBuilder(int lineId)
        {
            LineId = lineId;
        }

        public void BuildUrl()
        {
            var url = ApiPaths.ApiUrl;
            url += ApiPaths.Place.GetLines;

            Url = String.Format(url, LineId);
        }
    }
}
