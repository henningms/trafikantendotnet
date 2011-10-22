using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using Trafikanten.Common;
using Trafikanten.Common.QueryBuilder.Street;

namespace Trafikanten.Streets
{
    public class Streets
    {
        public static void GetStreets(GetStreetsQueryBuilder url, StreetCollectionDelegate callback)
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

                    var collection = Json.JsonHelper.Deserialize<IList<Street>>(e.Result);

                    callback(new ObservableCollection<Street>(collection));
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
