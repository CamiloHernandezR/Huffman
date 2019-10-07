using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{
    class codigo
    {
        char letra;
        string code;
        public codigo(char letra, string code)
        {
            this.letra = letra;
            this.code = code;
        }
        public codigo() { }
        public char Letra { get => letra; set => letra = value; }
        public string Code { get => code; set => code = value; }
    }
}
