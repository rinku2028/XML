using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace xml
{
    class xmlfilewrite
    {
        static void Main(string []args)
        {
            // Create an isntance of XmlTextReader and call Read method to read the file  
            XmlWriter xmlWriter = XmlWriter.Create("C:/Users/Dell/source/repos/xml/xmlfilewriter.xml");

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Users");

            xmlWriter.WriteStartElement("User");
            xmlWriter.WriteAttributeString("Age", "22");
            xmlWriter.WriteString("John Doe");
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("User");
            xmlWriter.WriteAttributeString("Age", "33");
            xmlWriter.WriteString("Jane Doe");

            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
            Console.ReadLine();
        }
        }
    }

