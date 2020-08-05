using DecisionsFramework.Design.Flow;
using DecisionsFramework.Design.Flow.CoreSteps.XML;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLtoJSON
{
    [AutoRegisterMethodsOnClass(true, "Data/XML")]
    public class XMLtoJsonClass
    {

        public string ConvertXmlToJson (string XML)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(XML);

            string json = JsonConvert.SerializeXmlNode(doc);
            return json;
        }

    }
}
