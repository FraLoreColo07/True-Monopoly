using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    [Serializable()]
    public class MElementi
    {
        public string Cartellino { get; set; }
        public string Posizione { get; set; }
        public int Denaro { get; set; }

        public MElementi()
        {
            Cartellino = "";
            Posizione = "";
            Denaro = 0;
        }

        public MElementi(string cartellino, int denaro, string posizione)
        {
            this.Cartellino = cartellino;
            this.Denaro = denaro;
            this.Posizione = posizione;
        }

       
    }
}
