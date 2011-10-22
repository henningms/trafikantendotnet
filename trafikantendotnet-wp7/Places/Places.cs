using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using Trafikanten.Common;
using Trafikanten.Common.QueryBuilder;
using Trafikanten.Json;
using Trafikanten.Common.QueryBuilder.Place;

namespace Trafikanten.Places
{
    public class Places
    {
        public static void GetCollectionAsync(IQueryBuilder url, Common.PlaceCollectionDelegate callback)
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

        public static void GetPlaceAsync(IQueryBuilder url, Common.PlaceDelegate callback)
        {
            try
            {
                if (url == null) throw new Exception("Cannot work with null-objects");
                if (String.IsNullOrEmpty(url.Url)) throw new Exception("Url cannot be empty");

                var client = new WebClient();

                client.DownloadStringCompleted += (s, e) =>
                {
                    if (e.Error != null) throw new Exception("", e.Error);
                    if (e.Result == null) return;

                    var collection = JsonHelper.Deserialize<Place>(e.Result);

                    callback(collection);
                };

                client.DownloadStringAsync(new Uri(url.Url));
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public static void GetLineAsync(IQueryBuilder url, Common.LineDelegate callback)
        {
            try
            {
                if (url == null) throw new Exception("Cannot work with null-objects");
                if (String.IsNullOrEmpty(url.Url)) throw new Exception("Url cannot be empty");

                var client = new WebClient();

                client.DownloadStringCompleted += (s, e) =>
                {
                    if (e.Error != null) throw new Exception("", e.Error);
                    if (e.Result == null) return;

                    var collection = JsonHelper.Deserialize<IList<Line>>(e.Result);

                    callback(new ObservableCollection<Line>(collection));
                };

                client.DownloadStringAsync(new Uri(url.Url));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void FindMatchesAsync(FindMatchesQueryBuilder url, Common.PlaceCollectionDelegate callback)
        {
            GetCollectionAsync(url, callback);
        }

        public static void FindMatchesByCountiesAsync(FindMatchesByCountiesQueryBuilder url, Common.PlaceCollectionDelegate callback)
        {
            GetCollectionAsync(url, callback);
        }

        public static void FindPlacesByCountiesAsync(FindMatchesByCountiesQueryBuilder url, Common.PlaceCollectionDelegate callback)
        {
            FindMatchesByCountiesAsync(url, callback);
        }

        public static void FindMatchesOfTypeAsync(FindMatchesOfTypeQueryBuilder url, Common.PlaceCollectionDelegate callback)
        {
            GetCollectionAsync(url, callback);
        }

        public static void FindPlaceBasedOnPlaceIdAsync(FindPlaceBasedOnPlaceIdQueryBuilder url, Common.PlaceDelegate callback)
        {
            GetPlaceAsync(url, callback);
        }

        public static void GetStopsByPlaceIdAsync(GetStopsByPlaceIdQueryBuilder url, Common.PlaceCollectionDelegate callback)
        {
            GetCollectionAsync(url, callback);
        }

        public static void GetClosestStopsAsync(GetClosestStopsQueryBuilder url, Common.PlaceCollectionDelegate callback)
        {
            GetCollectionAsync(url, callback);
        }

        public static void GetClosestStopsByCoordinatesAsync(GetClosestStopsByCoordinatesQueryBuilder url, Common.PlaceCollectionDelegate callback)
        {
            GetCollectionAsync(url, callback);
        }

        public static void GetClosestStopsAdvancedByCoordinatesAsync(GetClosestStopsAdvancedByCoordinatesQueryBuilder url, Common.PlaceCollectionDelegate callback)
        {
            GetCollectionAsync(url, callback);
        }

        public static void GetLinesAsync(GetLinesQueryBuilder url, Common.PlaceCollectionDelegate callback)
        {
            GetCollectionAsync(url, callback);
        }

        public static void AutoCompleteAsync(AutoCompleteQueryBuilder url, Common.PlaceCollectionDelegate callback)
        {
            GetCollectionAsync(url, callback);
        }

    }
}
