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
         string cod;
        bool ban;
        public informacion(char let, int aparicion, int tot)
        {
            this.letra = let;
            this.aparicion = aparicion;
            prob(tot);
            this.ban = false;
        }
        public informacion( int aparicion, double probabilidad)
        {
            this.ban = true;
            this.aparicion = aparicion;
            this.probabilidad = probabilidad;
        }
        public char Letra { get => letra; set => letra = value; }
        public int Aparicion { get => aparicion; set => aparicion = value; }
        public double Probabilidad { get => probabilidad; set => probabilidad = value; }
        public string Cod { get => cod; set => cod = value; }
        public bool Ban { get => ban; set => ban = value; }

        public void prob(int tot)
        {
            this.Probabilidad = Math.Truncate(Convert.ToDouble(aparicion) / Convert.ToDouble( tot)*100)/100;
          
        }
    }
}
