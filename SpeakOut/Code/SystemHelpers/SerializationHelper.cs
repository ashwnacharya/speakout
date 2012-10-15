#region Usings
using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
#endregion endregion

namespace SpeakYourMind.SystemHelpers
{
    public class SerializationHelper
    {
        public static string Serialize(Type t, object o)
        {
            if (o == null)
            {
                return String.Empty;
            }

            MemoryStream memoryStream = new MemoryStream();
            {

                try
                {
                    string XmlizedString = String.Empty;


                    XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, new UTF8Encoding());
                    XmlSerializer x = new XmlSerializer(t);
                    x.Serialize(xmlTextWriter, o);

                    memoryStream = (MemoryStream)xmlTextWriter.BaseStream;
                    XmlizedString = ByteArrayToString(memoryStream.ToArray());
                    memoryStream.Close();
                    memoryStream.Dispose();

                    return XmlizedString;
                }
                catch (Exception e)
                {

                    throw new Exception("Failed to serialise the object", e);
                }
            }

        }

        public static object Deserialize(Type t, string s)
        {
            if (String.IsNullOrEmpty(s))
            {
                return null;
            }

            try
            {

                XmlSerializer x = new XmlSerializer(t);
                using (MemoryStream memoryStream = new MemoryStream(StringToByteArray(s)))
                {
                    using (XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8))
                    {
                        Object o = x.Deserialize(memoryStream);
                        return o;
                    }
                }


            }
            catch (Exception e)
            {
                throw new Exception("Failed to deserialise the object", e);
            }

        }

        public static Byte[] StringToByteArray(String pXmlString)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            Byte[] byteArray = encoding.GetBytes(pXmlString);
            return byteArray;
        }

        public static String ByteArrayToString(Byte[] characters)
        {

            UTF8Encoding encoding = new UTF8Encoding();
            string constructedString = encoding.GetString(characters);
            return constructedString;
        }
    }
}
