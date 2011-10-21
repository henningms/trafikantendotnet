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

namespace Trafikanten.Common
{
    public class ApiPaths
    {
        public static string ApiUrl = "http://api-test.trafikanten.no/";

        public class Place
        {
            public static string FindMatches = "Place/FindMatches/{0}";
            public static string FindMatchesByCounties = "Place/FindMatchesByCounties/{0}";
            public static string FindPlacesByCounties = "Place/FindPlacesByCounties/{0}";
            public static string FindMatchesOfType = "Place/FindMatchesOfType/{0}";
            public static string FindPlaceBasedOnPlaceId = "Place/FindPlaceBasedOnPlaceId/{0}";
            public static string GetStopsByPlaceId = "Place/GetStopsByPlaceId/{0}";
            public static string GetClosestStops = "Place/GetClosestStops/{0}";
            public static string GetClosestStopsByCoordinates = "Place/GetClosestStopsByCoordinates/";
            public static string GetClosestStopsAdvancedByCoordinates = "Place/GetClosestStopsAdvancedByCoordinates/{0}";
            public static string GetLines = "Place/GetLines/{0}";
            public static string Autocomplete = "Place/Autocomplete/{0}";
        }

        public class Realtime
        {
            public static string FindMatches = "RealTime/FindMatches/{0}";
            public static string GetRealTimeData = "RealTime/GetRealTimeData/{0}";
            public static string IsUniquePlace = "RealTime/IsUniquePlace/{0}";
            public static string IsValidPlace = "RealTime/IsValidPlace/{0}";
        }

        public class Street
        {
            public static string GetStreets = "Street/GetStreets/{0}";
        }

        public class Travel
        {
            public static string GetTravelsAfter = "Travel/GetTravelsAfter?{0}";
            public static string GetTravelsBefore = "Travel/GetTravelsBefore?{0}";
            public static string GetTravelsAfterByStops = "Travel/GetTravelsAfterByStops?{0}";
            public static string GetTravelsBeforeByStops = "Travel/GetTravelsBeforeByStops?{0}";
            public static string GetTravelsAdvanced = "Travel/GetTravelsAdvanced/?{0}";
            public static string GetTravelsAdvancedByCoordinates = "Travel/GetTravelsAdvancedByCoordinates/?{0}";
        }

        public class Travelstage
        {
            public static string GetArrivals = "Travelstage/GetArrivals/{0}";
            public static string GetArrivalsAdvanced = "Travelstage/GetArrivalsAdvanced/{0}";
            public static string GetDepartures = "Travelstage/GetDepartures/{0}";
            public static string GetDeparturesAdvanced = "Travelstage/GetDeparturesAdvanced/{0}";
        }

        public class Trip
        {
            public static string GetTrip = "Trip/GetTrip/{0}";
        }
    }
}
