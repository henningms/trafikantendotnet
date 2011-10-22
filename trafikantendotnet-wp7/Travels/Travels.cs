using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Trafikanten.Common;
using Trafikanten.Common.QueryBuilder;
using Trafikanten.Common.QueryBuilder.Travel;
using Trafikanten.Streets;

namespace Trafikanten.Travels
{
    public class Travels
    {
        public static void GetTravelCollectionAsync(IQueryBuilder url, TravelCollectionDelegate callback)
        {
            try
            {
                if (url == null) throw new Exception("Cannot work with null-objects");
                if (String.IsNullOrEmpty(url.Url)) throw new Exception("Url cannot be empty");

                var client = new WebClient();

                client.DownloadStringCompleted += (s, e) =>
                {
                    if (e.Error != null) throw e.Error;
                    if (e.Result == null) return;

                    var collection = Json.JsonHelper.Deserialize<IList<Travel>>(e.Result);

                    callback(new ObservableCollection<Travel>(collection));
                };

                client.DownloadStringAsync(new Uri(url.Url));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void GetTravelsAfterAsync(GetTravelsAfterQueryBuilder url, TravelCollectionDelegate callback)
        {
            GetTravelCollectionAsync(url, callback);
        }

        public static void GetTravelsBeforeAsync(GetTravelsBeforeQueryBuilder url, TravelCollectionDelegate callback)
        {
            GetTravelCollectionAsync(url, callback);
        }

        public static void GetTravelsAfterByStopsAsync(GetTravelsAfterByStopsQueryBuilder url, TravelCollectionDelegate callback)
        {
            GetTravelCollectionAsync(url, callback);
        }

        public static void GetTravelsBeforeByStopsAsync(GetTravelsBeforeByStopsQueryBuilder url, TravelCollectionDelegate callback)
        {
            GetTravelCollectionAsync(url, callback);
        }

        public static void GetTravelsAdvancedAsync(GetTravelsAdvancedQueryBuilder url, TravelCollectionDelegate callback)
        {
            GetTravelCollectionAsync(url, callback);
        }

        public static void GetTravelsAdvancedByCoordinates(GetTravelsAdvancedByCoordinatesQueryBuilder url, TravelCollectionDelegate callback)
        {
            GetTravelCollectionAsync(url, callback);
        }
    }
}
