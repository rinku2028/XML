
using System;
using System.Data;
using System.Xml;

namespace xml
{
    class helloworld
    {
        static void Main(string[] args)
        {
            
            // Create XmlReader object  and setup Stream between XML file and XML Reader
            using (XmlReader reader = XmlReader.Create(@"C:/Users/Dell/source/repos/xml/info.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        //return only when you have START tag  
                        switch (reader.Name.ToString())
                        {
                            case "Name":
                                Console.WriteLine("Name of the Element is : " + reader.ReadString());
                                break;
                            case "Location":
                                Console.WriteLine("Your Location is : " + reader.ReadString());
                                break;
                        }
                    }
                    Console.WriteLine("");
                }
            }
            Console.ReadKey();
        }
        }
    
}
