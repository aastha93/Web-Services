using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Net;
using System.Xml.Linq;
using System.IO;


// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	public string GetRobberyData(string longi, string lat)
	{
        string rqstURl = "https://azure.geodataservice.net/GeoDataService.svc/GetUSDemographics?longitude=" + longi + "&latitude=" + lat + "&includecrimedata=true";
	     HttpWebRequest rqst = (HttpWebRequest)WebRequest.Create(rqstURl);
        HttpWebResponse response = (HttpWebResponse)rqst.GetResponse();
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(response.GetResponseStream());
        XmlNodeList elemList = xmlDoc.GetElementsByTagName("Robbery");
       // string str1;
        for (int i = 0; i < elemList.Count; i++)
        {
            string str1 = elemList[i].InnerXml;
            //Console.WriteLine(elemList[i].InnerXml);
            return str1;
            
            
        }
        return "0";

        

    }
    public string GetRapeData(string longi, string lat)
    {
        string rqstURl = "https://azure.geodataservice.net/GeoDataService.svc/GetUSDemographics?longitude=" + longi + "&latitude=" + lat + "&includecrimedata=true";
        HttpWebRequest rqst = (HttpWebRequest)WebRequest.Create(rqstURl);
        HttpWebResponse response = (HttpWebResponse)rqst.GetResponse();
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(response.GetResponseStream());
        XmlNodeList elemList = xmlDoc.GetElementsByTagName("ForcibleRape");
        // string str1;
        for (int i = 0; i < elemList.Count; i++)
        {
            string str1 = elemList[i].InnerXml;
            //Console.WriteLine(elemList[i].InnerXml);
            return str1;


        }
        return "0";



    }
    public string GetBurgData(string longi, string lat)
    {
        string rqstURl = "https://azure.geodataservice.net/GeoDataService.svc/GetUSDemographics?longitude=" + longi + "&latitude=" + lat + "&includecrimedata=true";
        HttpWebRequest rqst = (HttpWebRequest)WebRequest.Create(rqstURl);
        HttpWebResponse response = (HttpWebResponse)rqst.GetResponse();
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(response.GetResponseStream());
        XmlNodeList elemList = xmlDoc.GetElementsByTagName("Burglary");
        // string str1;
        for (int i = 0; i < elemList.Count; i++)
        {
            string str1 = elemList[i].InnerXml;
            //Console.WriteLine(elemList[i].InnerXml);
            return str1;


        }
        return "0";
    }
    public string GetLTData(string longi, string lat)
    {
        string rqstURl = "https://azure.geodataservice.net/GeoDataService.svc/GetUSDemographics?longitude=" + longi + "&latitude=" + lat + "&includecrimedata=true";
        HttpWebRequest rqst = (HttpWebRequest)WebRequest.Create(rqstURl);
        HttpWebResponse response = (HttpWebResponse)rqst.GetResponse();
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(response.GetResponseStream());
        XmlNodeList elemList = xmlDoc.GetElementsByTagName("LarcenyTheft");
        // string str1;
        for (int i = 0; i < elemList.Count; i++)
        {
            string str1 = elemList[i].InnerXml;
            //Console.WriteLine(elemList[i].InnerXml);
            return str1;


        }
        return "0";
    }

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}

    public string str1 { get; set; }
}
