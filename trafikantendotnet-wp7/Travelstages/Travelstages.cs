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
using Trafikanten.Common.QueryBuilder.Travelstage;
using Trafikanten.Travels;

namespace Trafikanten.Travelstages
{
    public class Travelstages
    {
        public static void GetTravelstageCollectionAsync(IQueryBuilder url, TravelstageCollectionDelegate callback)
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

                    var collection = Json.JsonHelper.Deserialize<IList<Travelstage>>(e.Result);

                    callback(new ObservableCollection<Travelstage>(collection));
                };

                client.DownloadStringAsync(new Uri(url.Url));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void GetArrivalsAsync(GetArrivalsQueryBuilder url, TravelstageCollectionDelegate callback)
        {
            GetTravelstageCollectionAsync(url, callback);
        }

        public static void GetArrivalsAdvancedAsync(GetArrivalsAdvancedQueryBuilder url, TravelstageCollectionDelegate callback)
        {
            GetTravelstageCollectionAsync(url, callback);
        }

        public static void GetDeparturesAsync(GetDeparturesQueryBuilder url, TravelstageCollectionDelegate callback)
        {
            GetTravelstageCollectionAsync(url, callback);
        }

        public static void GetDeparturesAdvancesAsync(GetDeparturesAdvancedQueryBuilder url, TravelstageCollectionDelegate callback)
        {
            GetTravelstageCollectionAsync(url, callback);
        }
    }
}
