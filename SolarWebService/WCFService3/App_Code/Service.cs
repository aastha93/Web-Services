using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.IO;
using System.Net;
using System.Xml.Linq;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    static int flag = 0;
    public string  getSolarEnergyData(string longi, string lat)
    {
        
        
        
        string rqstURL = "http://developer.nrel.gov/api/solar/solar_resource/v1.xml?api_key=rwVrVata6dDGPidA0TITINJNMzE1F0bJM6AYL6fn&lat="+lat+"&lon="+longi;
       // XmlDocument file = GetResponse(rqstURL);
        HttpWebRequest rqst = (HttpWebRequest)WebRequest.Create(rqstURL);
        HttpWebResponse response = (HttpWebResponse)rqst.GetResponse();
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(response.GetResponseStream());
        // get anual data in an list 
        XmlNodeList elemList = xmlDoc.GetElementsByTagName("annual");
        float count = 0;
        
        for (int i = 0; i < elemList.Count;i++ )
        {
            string str1 = elemList[i].InnerXml;
            //Console.WriteLine(elemList[i].InnerXml);
            float num = float.Parse(str1);
            count = count + num;
        }
        float avg = count / 3;
        string str = Convert.ToString(avg);

        if (avg>6)
        {
            flag = 1;
        }
        


            return str;

    }
   public string f()
    {
        if (flag == 1)
            return "  feasible";
        else
            return "   not feasible";

    }
}
