using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace InternalSystemsLogXmlToJson
{
    class Program
    {
        static void Main(string[] args)
        {
            string contents = File.ReadAllText(ConstantData.pathToXMLFile);

            var a = Regex.Split(contents, "!#!");
            a = a.Take(a.Count() - 1).ToArray();
            foreach (string xml in a)
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                var json = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.None, true);
                Console.WriteLine(json);
            }
          
            
            
            Console.ReadKey();
        }
    }
}
