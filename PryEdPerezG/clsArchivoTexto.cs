using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agrego dos librerias que me 
//permite procesar archivos
using System.IO;
using System.Windows.Forms;

namespace PryEdPerezG
{
    internal class clsArchivoTexto
    {
        public string NomArchi = "colores.text";

        public void Grabar()
        {

            StreamWriter AD = new StreamWriter(NomArchi);
            AD.WriteLine();
            AD.Close();
        }

        public void Grabar(string Dato)
        {
            StreamWriter AD = new StreamWriter(NomArchi, true);
            AD.WriteLine(Dato);
            AD.Close();
        }

        public void Recorrer (ListBox lstDatos)
        {
            lstDatos.Items.Clear();
            string DatosLeidos = "";
            StreamReader AD = new StreamReader(NomArchi);
            DatosLeidos = AD.ReadLine();
            while (DatosLeidos != null) 
            {
                lstDatos.Items.Add(DatosLeidos);
                DatosLeidos = AD.ReadLine();
            }
            AD.Close();
        }
        public void Recorrer(ComboBox CmbDatos)
        {
            CmbDatos.Items.Clear();
            string DatosLeidos = "";
            StreamReader AD = new StreamReader(NomArchi);
            DatosLeidos = AD.ReadLine();
            while (DatosLeidos != null)
            {
                CmbDatos.Items.Add(DatosLeidos);
                DatosLeidos = AD.ReadLine();
            }
            AD.Close();
        }

        public void Recorrer(DataGridView DgvDatos)
        {
            DgvDatos.Rows.Clear();
            string DatosLeidos = "";
            StreamReader AD = new StreamReader(NomArchi);
            DatosLeidos = AD.ReadLine();
            while(DatosLeidos != null)
            {
                DgvDatos.Rows.Add(DatosLeidos);
                DatosLeidos = AD.ReadLine();
            }
            AD.Close();
        }
    }
}
