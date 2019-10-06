using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Huffman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
       
        List<string> prop = new List<string>();
        List<informacion> info = new List<informacion>();

        private void txtComenzar_Click(object sender, EventArgs e)
        {
            info.Clear();
            dtgProbabilidades.Rows.Clear();
            calcular();
            ordenar();
        }
        public void calcular()
        {
            List<char> caracteres = new List<char>();
            info.Clear();
            if (txtCadena.Text != null)
            {
                string cadena = txtCadena.Text;


                char[] separar = new char[cadena.Length];
                bool ban = false;
                cadena.CopyTo(0, separar, 0, cadena.Length);
                foreach (char let in separar)
                {
                    caracteres.Add(let);
                }
                MessageBox.Show("antes " + caracteres.Count);
                for (int x = 0; x < caracteres.Count; x++)
                {
                    int con = 0;
                    for (int y = 0; y <caracteres.Count; y++)
                    {
                        if (caracteres[x] == caracteres[y])
                        {
                            con++;
                            if (x != y)
                            {
                                caracteres.RemoveAt(y);
                                y--;
                            }

                        }
                    }

                    info.Add(new informacion(caracteres[x], con, cadena.Length)); //Creamos nuestros objetos y  los añadimos a la lista

                }

               
            }
        }
        public void ordenar()
        {
           //Ordenamos la lista en orden descendente 
            List<informacion> info2 = info.OrderByDescending(o => o.Probabilidad).ToList();
            foreach(informacion let in info2)
            {
                dtgProbabilidades.Rows.Add(let.Letra,let.Aparicion, let.Probabilidad);
            }
           
        }

    }
}
