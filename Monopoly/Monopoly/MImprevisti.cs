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
        private int countElement = 0;

        public MImprevisti() { }
        public void CreaListaImprevisti(string fileName)
        {
            FileXML.deserializza(out Imprevisti, "Imprevisti.xml");
            this.countElement = Imprevisti.Count;
        }
        private void setImprevisti()
        {
            Random rand = new Random();

            for (int i = 0, num = 0; i < Imprevisti.Count; i++)
            {
                num = rand.Next(countElement);
                swap(ref Imprevisti[i],ref Imprevisti[num]);
            }
        }

        private void swap(ref MElementi e1, ref MElementi e2)
        {
            MElementi temp = e1;
            e1 = e2;
            e2 = temp;
        }

    }
}
