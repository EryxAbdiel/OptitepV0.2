using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApp1
{
    class LectorXML
    {
        public void Leer()
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable("table1");
            dataTable.Columns.Add("col1", typeof(string));
            dataSet.Tables.Add(dataTable);

            //dataSet.ReadXml("C:/Users/Apex_Soporte/Documents/DESARROLLO/WindowsFormsApp1/WindowsFormsApp1/XML/prueba_DATOS.xml", XmlReadMode.ReadSchema);
            
            
            XmlReader xmlReader = XmlReader.Create("C:/Users/Apex_Soporte/Documents/DESARROLLO/WindowsFormsApp1/WindowsFormsApp1/XML/prueba_DATOS.xml");

            dataSet.ReadXml(xmlReader, XmlReadMode.IgnoreSchema);
            
            /*String Cadenaalv="";
            while (xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "elemento"))
                {
                    if (xmlReader.HasAttributes)
                    {
                        
                        Cadenaalv = Cadenaalv + xmlReader.GetAttribute("nombre") + ": " + xmlReader.GetAttribute("desc") + "\n";
                            
                        //Console.WriteLine(xmlReader.GetAttribute("currency") + ": " + xmlReader.GetAttribute("rate"));
                    }
                }
                
            }
            MessageBox.Show(Cadenaalv);*/
        }


        /*public void Leer()
        {
            String Cadenaalv = "";
            XmlDocument doc = new XmlDocument();
            doc.Load("http://www.ecb.int/stats/eurofxref/eurofxref-daily.xml");
            XmlNodeReader nodereader = new XmlNodeReader(doc);
            while (nodereader.Read())
            {
                Cadenaalv = Cadenaalv + nodereader.Value;
            }
            MessageBox.Show(Cadenaalv);
        }*/
    }
}
