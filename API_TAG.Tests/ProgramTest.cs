using System.Collections.Generic;
using API_TAG;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace API_TAG.Tests
{
    [TestClass]
    [TestSubject(typeof(Program))]
    public class ProgramTest
    {

        [TestMethod]
        public void Test()
        {
            FakeStopByCoord stops = new FakeStopByCoord();
            List<BusStop> maListe = stops.GetStopList;
            Assert.AreEqual("SEM:0493",maListe[0].Id);
            Assert.AreEqual("Saint-Martin-d'Hères, Edmond Rostand",maListe[0].Name);
            Assert.AreEqual("5.75432",maListe[0].Lon);
            Assert.AreEqual("45.17446",maListe[0].Lat);
            
        }
        
    }
}