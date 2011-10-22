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
            public static string GetTravelsAfter = "Travel/GetTravelsAfter?";
            public static string GetTravelsBefore = "Travel/GetTravelsBefore?";
            public static string GetTravelsAfterByStops = "Travel/GetTravelsAfterByStops?";
            public static string GetTravelsBeforeByStops = "Travel/GetTravelsBeforeByStops?";
            public static string GetTravelsAdvanced = "Travel/GetTravelsAdvanced/?";
            public static string GetTravelsAdvancedByCoordinates = "Travel/GetTravelsAdvancedByCoordinates/?";
        }

        public class Travelstage
        {
            public static string GetArrivals = "Travelstage/GetArrivals/";
            public static string GetArrivalsAdvanced = "Travelstage/GetArrivalsAdvanced/";
            public static string GetDepartures = "Travelstage/GetDepartures/";
            public static string GetDeparturesAdvanced = "Travelstage/GetDeparturesAdvanced/";
        }

        public class Trip
        {
            public static string GetTrip = "Trip/GetTrip/{0}";
        }
    }
}
