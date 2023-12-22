using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace API_TAG
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ServicePointManager.SecurityProtocol=SecurityProtocolType.Tls12|SecurityProtocolType.Tls11 |
                                                 SecurityProtocolType.Tls;
            
            
            Request req =
                new Request(
                    "http://data.mobilites-m.fr/api/linesNear/json?y=45.176263&x=5.753379&dist=1000&details=true");
            // Console.WriteLine(req.getFullResp);
            List<TransportLine> lignes = req.GetStopList;
            Console.WriteLine(lignes[0].Name);
            
            req.CloseConnections();
        }
    }
}