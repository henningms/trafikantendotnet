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
    public class GetTravelsAfterQueryBuilder : IQueryBuilder
    {
        public string Url
        {
            get;
            set;
        }

        private String _time;
        public String Time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = value;
                BuildUrl();
            }
        }

        private int _fromStop;
        public int From
        {
            get
            {
                return _fromStop;
            }
            set
            {
                _fromStop = value;
                BuildUrl();
            }
        }

        private int _toStop;
        public int To
        {
            get
            {
                return _toStop;
            }
            set
            {
                _toStop = value;
                BuildUrl();
            }
        }

        public GetTravelsAfterQueryBuilder()
        {
            
        }

        public GetTravelsAfterQueryBuilder(String time, int from, int to)
        {
            Time = time;
            From = from;
            To = to;
        }

        public virtual void BuildUrl()
        {
            if (String.IsNullOrEmpty(Time)) return;

            var url = ApiPaths.ApiUrl + ApiPaths.Travel.GetTravelsAfter;

            Url = String.Format(url + "time={0}&from={1}&to={2}", Time, From, To);
        }
    }
}
