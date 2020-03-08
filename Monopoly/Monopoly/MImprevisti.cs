using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class MImprevisti
    {
        private List<MElementi> Imprevisti = null;

        public MImprevisti() { }
        public void CreaListaImprevisti(string fileName)
        {
            FileXML.deserializza(out Imprevisti, "Imprevisti.xml");
            //prova
        }

    }
}
