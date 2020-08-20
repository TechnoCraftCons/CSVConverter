using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string delimiter = ",";

            // replace your location to the xml file
            XDocument.Load(@"C:\Users\nebiy\source\repos\ConsoleApp1\ConsoleApp1\XMLFile1.xml").Descendants("Item").ToList().ForEach(
                element => sb.Append(
                                     element.Element("SNO").Value + delimiter +
                                     element.Element("DELV_DATE").Value + delimiter +
                                      element.Element("STORE_CD").Value + delimiter +
                                     element.Element("ITEM_CD").Value + delimiter +
                                     element.Element("ITEM_LONG_NAME").Value + delimiter +
                                     element.Element("BARCODE_NO").Value + delimiter +
                                      element.Element("ORD_SLIP_NO").Value + delimiter +
                                     element.Element("PSA_CD").Value + delimiter +
                                     element.Element("ORD_QTY").Value + delimiter +
                                     element.Element("ITEM_UNIT_COST").Value + delimiter +
                                     element.Element("ITEM_UNIT_PRICE").Value + "\r\n"));
            // replace your location to the new csv file
            StreamWriter sw = new StreamWriter(@"C:\Users\nebiy\source\repos\ConsoleApp1\ConsoleApp1\Result.csv");
            sw.WriteLine(sb.ToString());
            sw.Close();

          
        }
    }
}
