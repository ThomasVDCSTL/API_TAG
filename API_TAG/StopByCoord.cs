using System.Collections.Generic;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace API_TAG
{
    public class StopByCoord
    {
        private WebRequest _request;

        public WebResponse Response
        {
            get
            {
                return _request.GetResponse();
            }
        }
        public Stream DataStream
        {
            get
            {
                return Response.GetResponseStream();
            }
        }
        public StreamReader ReadData
        {
            get
            {
                return new StreamReader(DataStream);
            }
        }

        public string getFullResp
        {
            get
            {
                return ReadData.ReadToEnd();
            }
        }

        public List<BusStop> GetStopList
        {
            get
            {
                return new List<BusStop>(JsonConvert.DeserializeObject<List<BusStop>>(getFullResp));
            }
        }

        public StopByCoord(string x, string y, string rayon_m)
        {
            string url = "http://data.mobilites-m.fr/api/linesNear/json?y="+y+"&x="+x+"&dist="+rayon_m+"&details=true";
            _request = WebRequest.Create(url);
        }

        public void CloseConnections()
        {
            ReadData.Close ();
            DataStream.Close ();
            Response.Close ();
        }
    }
}