using System.Collections.Generic;
using System.Net;
using System.IO;
using API_TAG.Properties;
using Newtonsoft.Json;

namespace API_TAG
{
    public class StopByCoord : Request, ICoord
    {
        public string getFullResp()
        {
            return ReadData.ReadToEnd();
        }

        public List<BusStop> GetStopList
        {
            get
            {
                return new List<BusStop>(JsonConvert.DeserializeObject<List<BusStop>>(getFullResp()));
            }
        }

        public StopByCoord(string x, string y, string rayon_m) : base("http://data.mobilites-m.fr/api/linesNear/json?y="+y+"&x="+x+"&dist="+rayon_m+"&details=true")
        {
        }

        

        public void CloseConnections()
        {
            ReadData.Close ();
            DataStream.Close ();
            Response.Close ();
        }
    }
}