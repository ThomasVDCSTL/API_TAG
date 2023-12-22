using System.IO;
using System.Net;

namespace API_TAG.Properties
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

        public Request(string req)
        {
            _request = WebRequest.Create(req);
        }
    }
}