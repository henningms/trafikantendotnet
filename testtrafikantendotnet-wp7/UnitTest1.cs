using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trafikanten;
using Trafikanten.Places;
using Trafikanten.Common;

namespace testtrafikantendotnet_wp7
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Trafikanten.Common.PlaceDelegate dl = new PlaceDelegate(this.Lala);
        }

        public void Lala(ObservableCollection<Place> collection)
        {
            
        }
    }
}
