using System;
using System.Collections.ObjectModel;
using Trafikanten.Places;
using Trafikanten.Streets;
using Trafikanten.Travels;
using Trafikanten.Travelstages;
using Trafikanten.Trips;

namespace Trafikanten.Common
{
    public delegate void PlaceCollectionDelegate (ObservableCollection<Place> result);

    public delegate void PlaceDelegate(Place result);

    public delegate void LineDelegate(ObservableCollection<Line> result);

    public delegate void RealTimeDataDelegate(ObservableCollection<Station> result);

    public delegate void IsUniqueValidPlaceDelegate(Boolean? result);

    public delegate void StreetCollectionDelegate(ObservableCollection<Street> result);

    public delegate void TravelCollectionDelegate(ObservableCollection<Travel> result);

    public delegate void TravelstageCollectionDelegate(ObservableCollection<Travelstage> result);

    public delegate void TripDelegate(Trip result);
}
