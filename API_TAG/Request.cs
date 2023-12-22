using System.Collections.Generic;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace API_TAG
{
    public class Request
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

        public List<TransportLine> GetStopList
        {
            get
            {
                return new List<TransportLine>(JsonConvert.DeserializeObject<List<TransportLine>>(getFullResp));
            }
        }

        public Request(string url)
        {
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