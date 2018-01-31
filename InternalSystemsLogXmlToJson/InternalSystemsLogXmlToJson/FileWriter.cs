using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalSystemsLogXmlToJson
{
    class FileWriter
    {
        public void WriteToFile(string json)
        {
            File.AppendAllText(ConstantData.pathToJsonFile, json);
            File.AppendAllText(ConstantData.pathToJsonFile, Environment.NewLine);
        }
    }
}
