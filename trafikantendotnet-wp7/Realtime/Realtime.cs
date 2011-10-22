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
using Trafikanten.Common.QueryBuilder.Realtime;
using Trafikanten.Json;
using Trafikanten.Places;

namespace Trafikanten.Realtime
{
    public class Realtime
    {
        public static void GetStationCollectionAsync(IQueryBuilder url, RealTimeDataDelegate callback)
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

                    var collection = JsonHelper.Deserialize<
                        IList<Station>>(e.Result);

                    callback(new ObservableCollection<Station>(collection));
                };

                client.DownloadStringAsync(new Uri(url.Url));
            }
            catch (Exception)
            {
                throw;
            }

        }

        
        public static void GetRealTimeDataAsync(GetRealTimeDataQueryBuilder url, RealTimeDataDelegate callback)
        {
            GetStationCollectionAsync(url, callback);
        }

        public static void FindMatchesAsync(FindMatchesQueryBuilder url, PlaceCollectionDelegate callback)
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

                    var collection = JsonHelper.Deserialize<
                        IList<Place>>(e.Result);

                    callback(new ObservableCollection<Place>(collection));
                };

                client.DownloadStringAsync(new Uri(url.Url));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void IsUniquePlaceAsync(IsUniquePlaceQueryBuilder url, IsUniqueValidPlaceDelegate callback)
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

                    var unique = Convert.ToBoolean(e.Result);

                    callback(unique);
                };

                client.DownloadStringAsync(new Uri(url.Url));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void IsValidPlaceAsync(IsValidPlaceQueryBuilder url, IsUniqueValidPlaceDelegate callback)
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

                    var unique = Convert.ToBoolean(e.Result);

                    callback(unique);
                };

                client.DownloadStringAsync(new Uri(url.Url));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
