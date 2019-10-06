using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{
    class informacion
    {
        char letra;
        int aparicion;
        double probabilidad;
        public informacion(char let, int aparicion, int tot)
        {
            this.letra = let;
            this.aparicion = aparicion;
            prob(tot);
        }
        public char Letra { get => letra; set => letra = value; }
        public int Aparicion { get => aparicion; set => aparicion = value; }
        public double Probabilidad { get => probabilidad; set => probabilidad = value; }

        public void prob(int tot)
        {
            this.Probabilidad = Convert.ToDouble(aparicion) / Convert.ToDouble( tot);
        }
    }
}
