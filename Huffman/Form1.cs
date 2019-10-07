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
            txtCompresion.Enabled = false;
            txtComprimido.Enabled = false;
            TxtTam0.Enabled = false;
            txtTamN.Enabled = false;
        }

        int? tam0 = null, tamn = null;
        List<string> prop = new List<string>();
        List<nodo> nodos = new List<nodo>();
        List<informacion> info = new List<informacion>();
        List<codigo> codigos = new List<codigo>();

        private void txtComenzar_Click(object sender, EventArgs e)
        {
            if (txtCadena.Text != null)
            {
                info.Clear();
                nodos.Clear();
                dtgProbabilidades.Rows.Clear();
                calcular();
                ordenar();
                cor();
                comprimir(txtCadena.Text);
            }

        }
        public void comprimir(string cadena)
        {
            List<char> sus = new List<char>();
            sus.AddRange(cadena);
            string mensaje = null;
            foreach(char let in sus)
            {
                for(int x = 0; x < codigos.Count; x++)
                {
                    if (let == codigos[x].Letra)
                    {
                        mensaje = mensaje + codigos[x].Code;
                    }
                }
            }
            tamn = mensaje.Length;
           txtTamN.Text= mensaje.Length.ToString() + "   bits";
            txtComprimido.Text = mensaje;
            double compresion =Math.Round( Convert.ToDouble(tamn * 100) / Convert.ToDouble(tam0),3);
            txtCompresion.Text = compresion.ToString() + " %";
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
                tam0 = caracteres.Count * 8;
               TxtTam0.Text=tam0.ToString()+"  bits";
                for (int x = 0; x < caracteres.Count; x++)
                {
                    int con = 0;
                    for (int y = 0; y < caracteres.Count; y++)
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
            
            info = info.OrderByDescending(o => o.Probabilidad).ToList();

            foreach (informacion let in info)
            {
                dtgProbabilidades.Rows.Add(let.Letra, let.Aparicion, let.Probabilidad);
            }



            int y = info.Count - 1, x = y - 1, c = 1; 
           
            while (y > 0)
            {
                codigo(x, y);
             
                 c = c + 2; ;

                y = info.Count -  c; x = y - 1;
            }
            dtgProbabilidades.Rows.Add();
            foreach (informacion let in info)
            {
                string car;
                if (let.Ban == false)
                {
                    dtgProbabilidades.Rows.Add(let.Letra, let.Aparicion, let.Probabilidad);
                }
                else
                {
                    dtgProbabilidades.Rows.Add("Nod", let.Aparicion, let.Probabilidad);
                }
            }
        }
     
    public void cor()
        {
            int x = 0;
          dtgProbabilidades.Rows.Add("Codigos");
            for (x = (nodos.Count-2); x >= 0; x--)
            {
                nodos[x].Der.Info.Cod = nodos[x].Info.Cod + nodos[x].Der.Info.Cod;
                nodos[x].Izq.Info.Cod = nodos[x].Info.Cod + nodos[x].Izq.Info.Cod;
             
            }
            for (x = nodos.Count-1; x >= 0; x--)
            {
                
                    if (nodos[x].Izq.Info.Ban == false)
                    {




                        dtgProbabilidades.Rows.Add(nodos[x].Izq.Info.Letra, nodos[x].Izq.Info.Aparicion, nodos[x].Izq.Info.Probabilidad, nodos[x].Izq.Info.Cod);
                    codigos.Add(new codigo(nodos[x].Izq.Info.Letra, nodos[x].Izq.Info.Cod));


                    }
                    else
                    {

                        dtgProbabilidades.Rows.Add("Nod", nodos[x].Izq.Info.Aparicion, nodos[x].Izq.Info.Probabilidad, nodos[x].Izq.Info.Cod);


                    }
                    if (nodos[x].Der.Info.Ban == false)
                    {
                        dtgProbabilidades.Rows.Add(nodos[x].Der.Info.Letra, nodos[x].Der.Info.Aparicion, nodos[x].Der.Info.Probabilidad,  nodos[x].Der.Info.Cod);
                    codigos.Add(new codigo(nodos[x].Der.Info.Letra, nodos[x].Der.Info.Cod));
                    }
                    else
                    {
                        dtgProbabilidades.Rows.Add("Nod", nodos[x].Der.Info.Aparicion, nodos[x].Der.Info.Probabilidad,  nodos[x].Der.Info.Cod);
                    }
                
            }
            
        }
            private void codigo(int x, int y)
        {
            info = info.OrderByDescending(o => o.Probabilidad).ToList();


            nodo izq;
            nodo der;
            if (info[x].Probabilidad <= info[y].Probabilidad)
            {
                info[x].Cod = "0";
                info[y].Cod = "1";
                izq = new nodo(null, null, info[x]);
                der = new nodo(null, null, info[y]);


            }
            else
            {
                
                info[y].Cod = "0";
                info[x].Cod = "1";
                izq = new nodo(null, null, info[y]);
                der = new nodo(null, null, info[x]);

            }
            informacion nuevo = new informacion((info[x].Aparicion + info[y].Aparicion), info[x].Probabilidad + info[y].Probabilidad);
            
            info.Add(nuevo);
            nodo pad = new nodo(izq, der, nuevo);
            nodos.Add(pad);
            info = info.OrderByDescending(o => o.Probabilidad).ToList();
      
         


        }

    }
}
