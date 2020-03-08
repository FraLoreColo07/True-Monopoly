using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Monopoly
{
    public class FileXML
    {
        static public void deserializza(out List<MElementi> lista,string fileName)
        {
            StreamReader SR = null;
            try
            {
                SR = new StreamReader(fileName);
                XmlSerializer myXML = new XmlSerializer(typeof(List<MElementi>));
                lista = (List<MElementi>)myXML.Deserialize(SR);
                SR.Close();

            }
            catch (Exception e)
            {

            }
            lista = null;
            
        }
    }
}
