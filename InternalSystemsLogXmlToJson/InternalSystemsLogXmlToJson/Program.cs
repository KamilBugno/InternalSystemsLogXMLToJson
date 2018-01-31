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
            var converter = new Converter();
            converter.Convert();
        }
    }
}
