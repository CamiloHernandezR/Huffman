using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{
    class nodo
    {
       
        informacion info;
        nodo izq, der;

      
        internal informacion Info { get => info; set => info = value; }
        internal nodo Izq { get => izq; set => izq = value; }
        internal nodo Der { get => der; set => der = value; }

        
        public nodo(nodo izq, nodo der, informacion info)
        {
            this.Info = info;
            this.Izq = izq;
            this.Der = der;
        }
        public nodo()
        {

        }
    }
}
