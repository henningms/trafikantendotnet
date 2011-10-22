using System;
using System.Collections.ObjectModel;
using Trafikanten.Places;

namespace Trafikanten.Common
{
    public delegate void PlaceCollectionDelegate (ObservableCollection<Place> result);

    public delegate void PlaceDelegate(Place result);

    public delegate void LineDelegate(ObservableCollection<Line> result);

    public delegate void RealTimeDataDelegate(ObservableCollection<Station> result);

    public delegate void IsUniqueValidPlaceDelegate(Boolean? result);
}
