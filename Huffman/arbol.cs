using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{
    class arbol
    {
        nodo raiz;
        public arbol()
        {
            raiz = null;
        }
        public void Insertar(informacion info)
        {
            nodo nuevo;
            nuevo = new nodo();
            nuevo.Info = info;
            nuevo.Izq = null;
            nuevo.Der = null;
            if (raiz == null)
            
                raiz = nuevo;
            
            else
            {
                nodo anterior = null, reco;
                reco = raiz;
                while (reco != null)
                {
                    anterior = reco;
                    if (info.Probabilidad <= reco.Info.Probabilidad)
                    
                        reco = reco.Izq;

                    

                    else
                    
                        reco = reco.Der;

                    
                    if (info.Probabilidad <= anterior.Info.Probabilidad)
                        anterior.Izq = nuevo;
                    else
                        anterior.Der = nuevo;
                }
            }

        }
    }
}
