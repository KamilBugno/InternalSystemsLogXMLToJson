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
    class Converter
    {
        string xmlContent;
        FileWriter fileWriter;

        public Converter()
        {
            xmlContent = File.ReadAllText(ConstantData.pathToXMLFile);
            fileWriter = new FileWriter();
        }

        public void Convert()
        {
            var modifiedXmlContent = SplitAndCutLastElement();

            foreach (string xml in modifiedXmlContent)
            {
                var doc = new XmlDocument();
                doc.LoadXml(xml);
                var json = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.None, true);
                fileWriter.WriteToFile(json);
            }
        }

        public string[] SplitAndCutLastElement()
        {
            var tag = "!#!";
            var splitted = Regex.Split(xmlContent, tag);
            var splittedWithoutLastElement = splitted.Take(splitted.Count() - 1).ToArray();
            return splittedWithoutLastElement;
        }
    }
}
