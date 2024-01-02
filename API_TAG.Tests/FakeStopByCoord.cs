using System.Collections.Generic;
using Newtonsoft.Json;

namespace API_TAG.Tests
{
    public class FakeStopByCoord : ICoord
    {
        public string getFullResp()
        {
            return
                """
                [{"id":"SEM:0493","name":"Saint-Martin-d'Hères, Edmond Rostand","lon":5.75432,"lat":45.17446,"zone":"SEM_GENEDROSTAN","lines":["SEM:12"]},{"id":"SEM:0877","name":"Grenoble, Bon Pasteur","lon":5.75147,"lat":45.17823,"zone":"SEM_GENBONPASTE","lines":["SEM:12"]},{"id":"SEM:0878","name":"Saint-Martin-d'Hères, Edmond Rostand","lon":5.75429,"lat":45.17441,"zone":"SEM_GENEDROSTAN","lines":["SEM:12"]},{"id":"SEM:1074","name":"Saint-Martin-d'Hères, Houille Blanche","lon":5.7517,"lat":45.17795,"zone":"SEM_GENHOUILLEB","lines":["SEM:12"]}]
                """;
        }

        public List<BusStop> GetStopList
        {
            get { return new List<BusStop>(JsonConvert.DeserializeObject<List<BusStop>>(getFullResp())); }
        }
        
    }
}