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
using Trafikanten.Common;
using Trafikanten.Common.QueryBuilder.Trip;
using Trafikanten.Json;
using Trafikanten.Places;

namespace Trafikanten.Trips
{
    public class Trips
    {
        public static void GetTripAsync(GetTripQueryBuilder url, TripDelegate callback)
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

                    var collection = JsonHelper.Deserialize<Trip>(e.Result);

                    callback(collection);
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
