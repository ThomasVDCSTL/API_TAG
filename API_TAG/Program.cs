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
            
            
            StopByCoord req = new StopByCoord("5.753379","45.176263","500");
            List<BusStop> arrets = req.GetStopList;
            foreach (BusStop arret in arrets)
            {
            Console.WriteLine(arret.Id);
            }
            
            req.CloseConnections();
        }
    }
}