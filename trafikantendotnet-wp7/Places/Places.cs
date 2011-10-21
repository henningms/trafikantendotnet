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
using Trafikanten.Json;
using Trafikanten.Common.QueryBuilder.Place;

namespace Trafikanten.Places
{
    public class Places
    {
        public static void FindMatchesAsync(FindMatchesQueryBuilder url, Common.PlaceDelegate callback)
        {
            try
            {
                var client = new WebClient();

                client.DownloadStringCompleted += (s, e) =>
                                                      {
                                                          if (e.Error != null) throw e.Error;
                                                          if (e.Result == null) return;

                                                          var collection = JsonHelper.Deserialize<
                                                              IList<Place.Place>>(e.Result);

                                                          callback(new ObservableCollection<Place.Place>(collection));
                                                      };

                client.DownloadStringAsync(new Uri(url.Url));
            }
            catch (Exception ex)
            {              
                throw ex;
            }
        }
    }
}
